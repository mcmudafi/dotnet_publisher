using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetPublisher.Forms {
    partial class MainForm : Form {
        const string FILENAME = "data.json";
        List<Global.Project> projects;
        List<int> batch = new List<int>();

        public MainForm () {
            InitializeComponent();

            if (File.Exists(FILENAME)) {
                projects = JsonSerializer.Deserialize<List<Global.Project>>(File.ReadAllText(FILENAME));
            }

            if (projects == null) {
                projects = new List<Global.Project>();
            }
        }

        private void MainForm_FormClosing (object sender, FormClosingEventArgs e) {
            projects = projects.Where(s => s.IsProjectSetup).ToList();
            var opts = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(FILENAME, JsonSerializer.Serialize(projects, opts));
        }

        private void MainForm_Load (object sender, EventArgs e) {
            cmbConfiguration.Items.Clear();
            foreach (var config in Enum.GetValues(typeof(Global.Configuration))) {
                cmbConfiguration.Items.Add(config);
            }
            cmbConfiguration.SelectedIndex = 0;

            cmbRuntime.Items.Clear();
            foreach (var runtime in Enum.GetValues(typeof(Global.Runtime))) {
                cmbRuntime.Items.Add(runtime);
            }
            cmbRuntime.SelectedIndex = 0;

            listProjects.Items.Clear();
            foreach (var project in projects) {
                listProjects.Items.Add($"{project.SolutionName} {project.Name}");
            }
            listProjects.SelectedIndex = -1;
        }

        #region Solutions
        private void listProjects_SelectedIndexChanged (object sender, EventArgs e) {
            var enabled = true;
            if (listProjects.SelectedIndex < 0) {
                enabled = false;
                txtSolutionName.Text = txtSolutionPath.Text = txtProjectName.Text = "";
                cmbProject.SelectedIndex = cmbConfiguration.SelectedIndex = cmbRuntime.SelectedIndex = -1;
                chkForce.Checked = chkSelfContained.Checked = false;
            }

            grpSolution.Enabled = grpProject.Enabled
                = btnDelete.Enabled = enabled;

            layoutParameters.Controls.Clear();
            layoutParameters.RowCount = 0;
            layoutParameters.RowStyles.Clear();

            if (!enabled) return;

            var project = projects[listProjects.SelectedIndex];
            txtSolutionName.Text = project.SolutionName;
            txtSolutionPath.Text = project.SolutionPath;

            cmbProject.Items.Clear();
            if (project.IsProjectSetup) {
                foreach (var proj in project.ProjectsInSolution) {
                    cmbProject.Items.Add(proj);
                }

                txtProjectName.Text = project.Name;
                cmbProject.SelectedItem = project.ProjectPath;
                cmbConfiguration.SelectedIndex = (int)project.Configuration;
                chkForce.Checked = project.ForceResolvePackages;
                chkSelfContained.Checked = project.IsSelfContained;
                cmbRuntime.SelectedIndex = (int)project.Runtime;

                foreach (var param in project.Parameters) {
                    int rowCount = layoutParameters.RowCount;
                    int rowIndex = rowCount - 1;

                    var txtKey = new TextBox {
                        Margin = new Padding(1),
                        Text = param.Key,
                        Dock = DockStyle.Fill
                    };
                    var txtValue = new TextBox {
                        Margin = new Padding(1),
                        Text = param.Value,
                        Dock = DockStyle.Fill
                    };
                    var btnDelete = new Button {
                        Margin = new Padding(1),
                        Text = "-",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Tag = rowIndex,
                        Dock = DockStyle.Fill
                    };
                    btnDelete.Click += btnDeleteParameter_Click;

                    layoutParameters.RowCount = rowCount + 1;
                    layoutParameters.RowStyles.Add(new RowStyle(SizeType.Absolute, 24));

                    layoutParameters.Controls.Add(txtKey);
                    layoutParameters.Controls.Add(txtValue);
                    layoutParameters.Controls.Add(btnDelete);
                }

                layoutParameters.RowCount = layoutParameters.RowCount + 1;
                layoutParameters.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            } else {
                grpProject.Enabled = false;
                txtProjectName.Text = "";
                cmbProject.SelectedIndex = cmbConfiguration.SelectedIndex = cmbRuntime.SelectedIndex = -1;
                chkForce.Checked = chkSelfContained.Checked = false;
            }
        }

        private void btnAdd_Click (object sender, EventArgs e) {
            var project = new Global.Project {
                Name = "",
                SolutionName = "<< New solution >>",
                SolutionPath = "<< Please change path >>"
            };
            projects.Add(project);
            listProjects.Items.Add("<< New project >>");
            listProjects.SelectedIndex = projects.Count - 1;
        }

        private void btnDelete_Click (object sender, EventArgs e) {
            var index = listProjects.SelectedIndex;
            projects.RemoveAt(index);
            listProjects.Items.RemoveAt(index);
            listProjects.SelectedIndex = -1;
        }

        private void btnSolutionPath_Click (object sender, EventArgs e) {
            var dialog = new OpenFileDialog {
                Filter = "Solution files (*.sln)|*.sln"
            };
            if (dialog.ShowDialog() == DialogResult.OK) {
                var project = projects[listProjects.SelectedIndex];

                project.SolutionName = txtSolutionName.Text = Path.GetFileNameWithoutExtension(dialog.FileName);
                project.SolutionPath =  txtSolutionPath.Text = Path.GetFullPath(dialog.FileName);

                cmbProject.Items.Clear();
                foreach (var proj in project.ProjectsInSolution) {
                    cmbProject.Items.Add(proj);
                }
                cmbProject.SelectedIndex = -1;
                grpProject.Enabled = true;
            }
        }
        #endregion

        #region Projects
        private void cmbProject_SelectedIndexChanged (object sender, EventArgs e) {
            if (cmbProject.SelectedIndex < 0) return;

            var project = projects[listProjects.SelectedIndex];
            project.ProjectPath = cmbProject.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(project.Name)) {
                txtProjectName.Text = Path.GetFileNameWithoutExtension(project.FullPath);
            }
        }

        private void btnBuildNow_Click (object sender, EventArgs e) {
            btnSave.PerformClick();

            var project = projects[listProjects.SelectedIndex];

            var form = new ProgressForm();
            form.Build(false, project);
        }

        private void btnAddToBatch_Click (object sender, EventArgs e) {
            batch.Add(listProjects.SelectedIndex);
            listBatch.Items.Add($"{txtSolutionName.Text} {txtProjectName.Text}");
            listBatch.SelectedIndex = -1;

            btnClearBatch.Enabled = btnBuildBatch.Enabled = true;
        }

        private void btnSave_Click (object sender, EventArgs e) {
            var project= projects[listProjects.SelectedIndex];
            project.SolutionName = txtSolutionName.Text;
            project.SolutionPath = txtSolutionPath.Text;
            project.Name = txtProjectName.Text;
            project.ProjectPath = cmbProject.SelectedItem.ToString();
            project.Configuration = (Global.Configuration)cmbConfiguration.SelectedIndex;
            project.IsSelfContained = chkSelfContained.Checked;
            project.Runtime = (Global.Runtime)cmbRuntime.SelectedIndex;
            project.ForceResolvePackages = chkForce.Checked;

            project.Parameters.Clear();
            for (int i = 0; i < layoutParameters.Controls.Count; i += 3) {
                project.Parameters.Add(new Global.Parameter(
                    layoutParameters.Controls[i].Text,
                    layoutParameters.Controls[i + 1].Text
                ));
            }

            var index = listProjects.SelectedIndex;
            listProjects.BeginUpdate();
            listProjects.Items[index] = $"{project.SolutionName} {project.Name}";
            listProjects.SelectedIndex = index;
            listProjects.EndUpdate();
        }

        private void chkSelfContained_CheckedChanged (object sender, EventArgs e) {
            lblRuntime.Enabled = cmbRuntime.Enabled = chkSelfContained.Checked;
        }

        #region Parameters
        private void btnAddParameter_Click (object sender, EventArgs e) {
            int rowCount = layoutParameters.RowCount;
            int rowIndex = rowCount - 1;

            var txtKey = new TextBox {
                Margin = new Padding(1),
                Text = "",
                Dock = DockStyle.Fill
            };
            var txtValue = new TextBox {
                Margin = new Padding(1),
                Text = "",
                Dock = DockStyle.Fill
            };
            var btnDelete = new Button {
                Margin = new Padding(1),
                Text = "-",
                TextAlign = ContentAlignment.MiddleCenter,
                Tag = rowIndex,
                Dock = DockStyle.Fill
            };
            btnDelete.Click += btnDeleteParameter_Click;

            layoutParameters.RowCount = rowCount + 1;
            layoutParameters.RowStyles.Insert(rowIndex, new RowStyle(SizeType.Absolute, 24));

            layoutParameters.Controls.Add(txtKey);
            layoutParameters.Controls.Add(txtValue);
            layoutParameters.Controls.Add(btnDelete);
        }

        private void btnDeleteParameter_Click (object sender, EventArgs e) {
            var index = (int)((Button)sender).Tag;
            for (int i = 0; i < 3; i++) {
                layoutParameters.Controls.RemoveAt(index * 3);
            }
            layoutParameters.RowStyles.RemoveAt(layoutParameters.RowCount - 2);
            layoutParameters.RowCount = layoutParameters.RowCount - 1;

            for (int i = 0; i < layoutParameters.Controls.Count / 3; i ++) {
                layoutParameters.Controls[i * 3 + 2].Tag = i;
            }
        }
        #endregion
        #endregion

        #region Batch
        private void listBatch_SelectedIndexChanged (object sender, EventArgs e) {
            if (listBatch.SelectedIndex < 0) {
                btnDeleteFromBatch.Enabled = false;
                return;
            }

            var index = batch[listBatch.SelectedIndex];
            listProjects.SelectedIndex = index;
            btnDeleteFromBatch.Enabled = true;
        }

        private void btnDeleteFromBatch_Click (object sender, EventArgs e) {
            var index = listBatch.SelectedIndex;
            batch.RemoveAt(index);
            listBatch.Items.RemoveAt(index);
            listBatch.SelectedIndex = -1;

            btnClearBatch.Enabled = btnBuildBatch.Enabled = listBatch.Items.Count > 0;
        }

        private void btnBuildBatch_Click (object sender, EventArgs e) {
            btnSave.PerformClick();

            var form = new ProgressForm();
            form.Build(true, batch.Select(i => projects[i]).ToArray());
        }

        private void btnClearBatch_Click (object sender, EventArgs e) {
            batch.Clear();
            listBatch.Items.Clear();

            btnClearBatch.Enabled = btnDeleteFromBatch.Enabled
                = btnBuildBatch.Enabled = false;
        }
        #endregion
    }
}
