using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetPublisher.Forms {
    partial class ProgressForm : Form {
        public ProgressForm () {
            InitializeComponent();
        }

        public void Build (bool isBatch, params Global.Project[] projects) {
            var thread = new Thread(new ThreadStart(() => {
                string dirName;
                bool result = true;

                if (isBatch) {
                    for (int i = 0; result && i < projects.Length; i++) {
                        var project = projects[i];
                        SetText(txtProgress, $"Building {project.Name} ... ({i + 1}/{projects.Length})");

                        result &= BuildProcess(project);
                    }

                    dirName = "build";
                } else {
                    var project = projects[0];
                    SetText(txtProgress, $"Building {project.Name} ...");
                    result &= BuildProcess(project);

                    dirName = $"build\\{project.SolutionName} {project.Name}";
                }

                if (result) {
                    var dialog = new SaveFileDialog();
                    dialog.Filter = "zip files (*.zip)|*.zip";
                    dialog.DefaultExt = "zip";
                    dialog.AddExtension = true;

                    var dialogResult = DialogResult.OK;
                    Invoke((MethodInvoker)delegate {
                        dialogResult = dialog.ShowDialog(this);
                    });

                    if (dialogResult == DialogResult.OK) {
                        if (File.Exists(dialog.FileName)) {
                            File.Delete(dialog.FileName);
                        }

                        SetText(txtOutput, $"{Environment.NewLine}Compressing to {dialog.FileName} ...", true);
                        ZipFile.CreateFromDirectory(dirName, dialog.FileName, CompressionLevel.Optimal, false);

                        MessageBox.Show($"Saved to {dialog.FileName}");
                    }
                }

                if (Directory.Exists("build")) {
                    Directory.Delete("build", true);
                }

                Thread.Sleep(1000);
                
                Invoke((MethodInvoker)delegate {
                    Close();
                });
            }));
            thread.Start();

            ShowDialog();
        }

        bool BuildProcess (Global.Project project) {
            SetText(txtOutput, $"dotnet {project.Command}{Environment.NewLine}", true);

            var psi = new ProcessStartInfo();
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.CreateNoWindow = true;
            psi.FileName = "dotnet";
            psi.Arguments = project.Command;

            var proc = Process.Start(psi);
            proc.OutputDataReceived += (sender, e) => {
                if (string.IsNullOrEmpty(e.Data)) {
                    SetText(txtOutput, Environment.NewLine, true);
                } else {
                    Invoke((MethodInvoker)delegate {
                        SetText(txtOutput, $"{e.Data}{Environment.NewLine}", true);
                    });
                }
            };
            proc.BeginOutputReadLine();
            proc.WaitForExit();

            if (proc.ExitCode != 0) {
                MessageBox.Show($"Build failed!\ndotnet {project.Command}");
                return false;
            }

            return true;
        }

        private void lblOutput_TextChanged (object sender, EventArgs e) {
            txtOutput.SelectionStart = txtOutput.Text.Length;
            txtOutput.SelectionLength = 0;
        }

        void SetText (TextBox control, string text, bool isAppend = false) {
            void _SetText () {
                if (isAppend) {
                    control.AppendText(text);
                } else {
                    control.Text = text;
                }
            }

            if (control.InvokeRequired) {
                Invoke((MethodInvoker)delegate {
                    _SetText();
                });
            } else {
                _SetText();
            }
        }
    }
}