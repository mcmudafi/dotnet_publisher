
namespace DotNetPublisher.Forms {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.listProjects = new System.Windows.Forms.ListBox();
            this.listBatch = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpSolution = new System.Windows.Forms.GroupBox();
            this.lblSolutionPath = new System.Windows.Forms.Label();
            this.lblSolutionName = new System.Windows.Forms.Label();
            this.btnSolutionPath = new System.Windows.Forms.Button();
            this.txtSolutionPath = new System.Windows.Forms.TextBox();
            this.txtSolutionName = new System.Windows.Forms.TextBox();
            this.grpProject = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.layoutParameters = new System.Windows.Forms.TableLayoutPanel();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddToBatch = new System.Windows.Forms.Button();
            this.btnBuildNow = new System.Windows.Forms.Button();
            this.btnAddParameter = new System.Windows.Forms.Button();
            this.lblParameters = new System.Windows.Forms.Label();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lblConfiguration = new System.Windows.Forms.Label();
            this.lblProjectPath = new System.Windows.Forms.Label();
            this.chkForce = new System.Windows.Forms.CheckBox();
            this.cmbRuntime = new System.Windows.Forms.ComboBox();
            this.cmbConfiguration = new System.Windows.Forms.ComboBox();
            this.chkSelfContained = new System.Windows.Forms.CheckBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBuildBatch = new System.Windows.Forms.Button();
            this.btnClearBatch = new System.Windows.Forms.Button();
            this.btnDeleteFromBatch = new System.Windows.Forms.Button();
            this.grpSolution.SuspendLayout();
            this.grpProject.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProjects
            // 
            this.listProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listProjects.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listProjects.FormattingEnabled = true;
            this.listProjects.ItemHeight = 17;
            this.listProjects.Location = new System.Drawing.Point(12, 12);
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(244, 463);
            this.listProjects.TabIndex = 0;
            this.listProjects.SelectedIndexChanged += new System.EventHandler(this.listProjects_SelectedIndexChanged);
            // 
            // listBatch
            // 
            this.listBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBatch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBatch.FormattingEnabled = true;
            this.listBatch.ItemHeight = 17;
            this.listBatch.Location = new System.Drawing.Point(732, 12);
            this.listBatch.Name = "listBatch";
            this.listBatch.Size = new System.Drawing.Size(237, 463);
            this.listBatch.TabIndex = 1;
            this.listBatch.SelectedIndexChanged += new System.EventHandler(this.listBatch_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(144, 484);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 26);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpSolution
            // 
            this.grpSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSolution.Controls.Add(this.lblSolutionPath);
            this.grpSolution.Controls.Add(this.lblSolutionName);
            this.grpSolution.Controls.Add(this.btnSolutionPath);
            this.grpSolution.Controls.Add(this.txtSolutionPath);
            this.grpSolution.Controls.Add(this.txtSolutionName);
            this.grpSolution.Enabled = false;
            this.grpSolution.Location = new System.Drawing.Point(262, 12);
            this.grpSolution.Name = "grpSolution";
            this.grpSolution.Size = new System.Drawing.Size(464, 88);
            this.grpSolution.TabIndex = 3;
            this.grpSolution.TabStop = false;
            this.grpSolution.Text = "Solution";
            // 
            // lblSolutionPath
            // 
            this.lblSolutionPath.AutoSize = true;
            this.lblSolutionPath.Location = new System.Drawing.Point(6, 55);
            this.lblSolutionPath.Name = "lblSolutionPath";
            this.lblSolutionPath.Size = new System.Drawing.Size(78, 15);
            this.lblSolutionPath.TabIndex = 10;
            this.lblSolutionPath.Text = "Solution path";
            // 
            // lblSolutionName
            // 
            this.lblSolutionName.AutoSize = true;
            this.lblSolutionName.Location = new System.Drawing.Point(6, 25);
            this.lblSolutionName.Name = "lblSolutionName";
            this.lblSolutionName.Size = new System.Drawing.Size(39, 15);
            this.lblSolutionName.TabIndex = 9;
            this.lblSolutionName.Text = "Name";
            // 
            // btnSolutionPath
            // 
            this.btnSolutionPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolutionPath.Location = new System.Drawing.Point(427, 51);
            this.btnSolutionPath.Name = "btnSolutionPath";
            this.btnSolutionPath.Size = new System.Drawing.Size(31, 23);
            this.btnSolutionPath.TabIndex = 9;
            this.btnSolutionPath.Text = "...";
            this.btnSolutionPath.UseVisualStyleBackColor = true;
            this.btnSolutionPath.Click += new System.EventHandler(this.btnSolutionPath_Click);
            // 
            // txtSolutionPath
            // 
            this.txtSolutionPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolutionPath.Location = new System.Drawing.Point(98, 51);
            this.txtSolutionPath.Name = "txtSolutionPath";
            this.txtSolutionPath.ReadOnly = true;
            this.txtSolutionPath.Size = new System.Drawing.Size(323, 23);
            this.txtSolutionPath.TabIndex = 1;
            // 
            // txtSolutionName
            // 
            this.txtSolutionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolutionName.Location = new System.Drawing.Point(98, 22);
            this.txtSolutionName.Name = "txtSolutionName";
            this.txtSolutionName.Size = new System.Drawing.Size(360, 23);
            this.txtSolutionName.TabIndex = 0;
            // 
            // grpProject
            // 
            this.grpProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProject.Controls.Add(this.panel1);
            this.grpProject.Controls.Add(this.lblProjectName);
            this.grpProject.Controls.Add(this.txtProjectName);
            this.grpProject.Controls.Add(this.btnSave);
            this.grpProject.Controls.Add(this.btnAddToBatch);
            this.grpProject.Controls.Add(this.btnBuildNow);
            this.grpProject.Controls.Add(this.btnAddParameter);
            this.grpProject.Controls.Add(this.lblParameters);
            this.grpProject.Controls.Add(this.lblRuntime);
            this.grpProject.Controls.Add(this.lblConfiguration);
            this.grpProject.Controls.Add(this.lblProjectPath);
            this.grpProject.Controls.Add(this.chkForce);
            this.grpProject.Controls.Add(this.cmbRuntime);
            this.grpProject.Controls.Add(this.cmbConfiguration);
            this.grpProject.Controls.Add(this.chkSelfContained);
            this.grpProject.Controls.Add(this.cmbProject);
            this.grpProject.Enabled = false;
            this.grpProject.Location = new System.Drawing.Point(262, 106);
            this.grpProject.Name = "grpProject";
            this.grpProject.Size = new System.Drawing.Size(464, 404);
            this.grpProject.TabIndex = 4;
            this.grpProject.TabStop = false;
            this.grpProject.Text = "Project";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.layoutParameters);
            this.panel1.Location = new System.Drawing.Point(134, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 251);
            this.panel1.TabIndex = 27;
            // 
            // layoutParameters
            // 
            this.layoutParameters.ColumnCount = 3;
            this.layoutParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.layoutParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layoutParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.layoutParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutParameters.Location = new System.Drawing.Point(0, 0);
            this.layoutParameters.Name = "layoutParameters";
            this.layoutParameters.RowCount = 1;
            this.layoutParameters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutParameters.Size = new System.Drawing.Size(324, 251);
            this.layoutParameters.TabIndex = 19;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(6, 25);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(39, 15);
            this.lblProjectName.TabIndex = 26;
            this.lblProjectName.Text = "Name";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectName.Location = new System.Drawing.Point(98, 22);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(132, 23);
            this.txtProjectName.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(6, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 32);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddToBatch
            // 
            this.btnAddToBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToBatch.Location = new System.Drawing.Point(237, 366);
            this.btnAddToBatch.Name = "btnAddToBatch";
            this.btnAddToBatch.Size = new System.Drawing.Size(114, 32);
            this.btnAddToBatch.TabIndex = 23;
            this.btnAddToBatch.Text = "Add to batch";
            this.btnAddToBatch.UseVisualStyleBackColor = true;
            this.btnAddToBatch.Click += new System.EventHandler(this.btnAddToBatch_Click);
            // 
            // btnBuildNow
            // 
            this.btnBuildNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuildNow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuildNow.ForeColor = System.Drawing.Color.Blue;
            this.btnBuildNow.Location = new System.Drawing.Point(357, 366);
            this.btnBuildNow.Name = "btnBuildNow";
            this.btnBuildNow.Size = new System.Drawing.Size(101, 32);
            this.btnBuildNow.TabIndex = 22;
            this.btnBuildNow.Text = "BUILD NOW";
            this.btnBuildNow.UseVisualStyleBackColor = true;
            this.btnBuildNow.Click += new System.EventHandler(this.btnBuildNow_Click);
            // 
            // btnAddParameter
            // 
            this.btnAddParameter.Location = new System.Drawing.Point(98, 109);
            this.btnAddParameter.Name = "btnAddParameter";
            this.btnAddParameter.Size = new System.Drawing.Size(30, 23);
            this.btnAddParameter.TabIndex = 21;
            this.btnAddParameter.Text = "+";
            this.btnAddParameter.UseVisualStyleBackColor = true;
            this.btnAddParameter.Click += new System.EventHandler(this.btnAddParameter_Click);
            // 
            // lblParameters
            // 
            this.lblParameters.AutoSize = true;
            this.lblParameters.Location = new System.Drawing.Point(4, 113);
            this.lblParameters.Name = "lblParameters";
            this.lblParameters.Size = new System.Drawing.Size(66, 15);
            this.lblParameters.TabIndex = 20;
            this.lblParameters.Text = "Parameters";
            // 
            // lblRuntime
            // 
            this.lblRuntime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Enabled = false;
            this.lblRuntime.Location = new System.Drawing.Point(253, 54);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(52, 15);
            this.lblRuntime.TabIndex = 17;
            this.lblRuntime.Text = "Runtime";
            // 
            // lblConfiguration
            // 
            this.lblConfiguration.AutoSize = true;
            this.lblConfiguration.Location = new System.Drawing.Point(4, 83);
            this.lblConfiguration.Name = "lblConfiguration";
            this.lblConfiguration.Size = new System.Drawing.Size(81, 15);
            this.lblConfiguration.TabIndex = 15;
            this.lblConfiguration.Text = "Configuration";
            // 
            // lblProjectPath
            // 
            this.lblProjectPath.AutoSize = true;
            this.lblProjectPath.Location = new System.Drawing.Point(4, 54);
            this.lblProjectPath.Name = "lblProjectPath";
            this.lblProjectPath.Size = new System.Drawing.Size(68, 15);
            this.lblProjectPath.TabIndex = 14;
            this.lblProjectPath.Text = "ProjectPath";
            // 
            // chkForce
            // 
            this.chkForce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkForce.AutoSize = true;
            this.chkForce.Location = new System.Drawing.Point(253, 24);
            this.chkForce.Name = "chkForce";
            this.chkForce.Size = new System.Drawing.Size(95, 19);
            this.chkForce.TabIndex = 13;
            this.chkForce.Text = "Force resolve";
            this.chkForce.UseVisualStyleBackColor = true;
            // 
            // cmbRuntime
            // 
            this.cmbRuntime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRuntime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRuntime.Enabled = false;
            this.cmbRuntime.FormattingEnabled = true;
            this.cmbRuntime.Location = new System.Drawing.Point(347, 51);
            this.cmbRuntime.Name = "cmbRuntime";
            this.cmbRuntime.Size = new System.Drawing.Size(111, 23);
            this.cmbRuntime.TabIndex = 12;
            // 
            // cmbConfiguration
            // 
            this.cmbConfiguration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConfiguration.FormattingEnabled = true;
            this.cmbConfiguration.Location = new System.Drawing.Point(98, 80);
            this.cmbConfiguration.Name = "cmbConfiguration";
            this.cmbConfiguration.Size = new System.Drawing.Size(130, 23);
            this.cmbConfiguration.TabIndex = 11;
            // 
            // chkSelfContained
            // 
            this.chkSelfContained.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSelfContained.AutoSize = true;
            this.chkSelfContained.Location = new System.Drawing.Point(357, 24);
            this.chkSelfContained.Name = "chkSelfContained";
            this.chkSelfContained.Size = new System.Drawing.Size(101, 19);
            this.chkSelfContained.TabIndex = 10;
            this.chkSelfContained.Text = "Self contained";
            this.chkSelfContained.UseVisualStyleBackColor = true;
            this.chkSelfContained.CheckedChanged += new System.EventHandler(this.chkSelfContained_CheckedChanged);
            // 
            // cmbProject
            // 
            this.cmbProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(98, 51);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(132, 23);
            this.cmbProject.TabIndex = 9;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(12, 484);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 26);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "!! Delete !!";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBuildBatch
            // 
            this.btnBuildBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuildBatch.Enabled = false;
            this.btnBuildBatch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuildBatch.ForeColor = System.Drawing.Color.Blue;
            this.btnBuildBatch.Location = new System.Drawing.Point(894, 484);
            this.btnBuildBatch.Name = "btnBuildBatch";
            this.btnBuildBatch.Size = new System.Drawing.Size(75, 26);
            this.btnBuildBatch.TabIndex = 6;
            this.btnBuildBatch.Text = "BUILD";
            this.btnBuildBatch.UseVisualStyleBackColor = true;
            this.btnBuildBatch.Click += new System.EventHandler(this.btnBuildBatch_Click);
            // 
            // btnClearBatch
            // 
            this.btnClearBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearBatch.Enabled = false;
            this.btnClearBatch.ForeColor = System.Drawing.Color.Red;
            this.btnClearBatch.Location = new System.Drawing.Point(732, 484);
            this.btnClearBatch.Name = "btnClearBatch";
            this.btnClearBatch.Size = new System.Drawing.Size(75, 26);
            this.btnClearBatch.TabIndex = 3;
            this.btnClearBatch.Text = "!! Clear !!";
            this.btnClearBatch.UseVisualStyleBackColor = true;
            this.btnClearBatch.Click += new System.EventHandler(this.btnClearBatch_Click);
            // 
            // btnDeleteFromBatch
            // 
            this.btnDeleteFromBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFromBatch.Enabled = false;
            this.btnDeleteFromBatch.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteFromBatch.Location = new System.Drawing.Point(813, 484);
            this.btnDeleteFromBatch.Name = "btnDeleteFromBatch";
            this.btnDeleteFromBatch.Size = new System.Drawing.Size(75, 26);
            this.btnDeleteFromBatch.TabIndex = 7;
            this.btnDeleteFromBatch.Text = "!! Delete !!";
            this.btnDeleteFromBatch.UseVisualStyleBackColor = true;
            this.btnDeleteFromBatch.Click += new System.EventHandler(this.btnDeleteFromBatch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 522);
            this.Controls.Add(this.btnDeleteFromBatch);
            this.Controls.Add(this.btnClearBatch);
            this.Controls.Add(this.btnBuildBatch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grpProject);
            this.Controls.Add(this.grpSolution);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBatch);
            this.Controls.Add(this.listProjects);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".NET Projects Publisher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpSolution.ResumeLayout(false);
            this.grpSolution.PerformLayout();
            this.grpProject.ResumeLayout(false);
            this.grpProject.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listProjects;
        private System.Windows.Forms.ListBox listBatch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpSolution;
        private System.Windows.Forms.TextBox txtSolutionPath;
        private System.Windows.Forms.TextBox txtSolutionName;
        private System.Windows.Forms.GroupBox grpProject;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBuildBatch;
        private System.Windows.Forms.Button btnClearBatch;
        private System.Windows.Forms.Label lblSolutionPath;
        private System.Windows.Forms.Label lblSolutionName;
        private System.Windows.Forms.Button btnSolutionPath;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Button btnAddParameter;
        private System.Windows.Forms.Label lblParameters;
        private System.Windows.Forms.TableLayoutPanel layoutParameters;
        private System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.Label lblConfiguration;
        private System.Windows.Forms.Label lblProjectPath;
        private System.Windows.Forms.CheckBox chkForce;
        private System.Windows.Forms.ComboBox cmbRuntime;
        private System.Windows.Forms.ComboBox cmbConfiguration;
        private System.Windows.Forms.CheckBox chkSelfContained;
        private System.Windows.Forms.Button btnAddToBatch;
        private System.Windows.Forms.Button btnBuildNow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Button btnDeleteFromBatch;
        private System.Windows.Forms.Panel panel1;
    }
}

