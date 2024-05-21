namespace IssueTicketingSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnReportIssue = new System.Windows.Forms.Button();
            this.btnDeveloperManagement = new System.Windows.Forms.Button();
            this.btnResolveIssue = new System.Windows.Forms.Button();
            this.ssMainForm = new System.Windows.Forms.StatusStrip();
            this.lvResolutions = new System.Windows.Forms.ListView();
            this.colIssueTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSeverity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSolved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDeveloperName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsResolutions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsResolutions.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReportIssue
            // 
            this.btnReportIssue.Location = new System.Drawing.Point(39, 66);
            this.btnReportIssue.Name = "btnReportIssue";
            this.btnReportIssue.Size = new System.Drawing.Size(149, 51);
            this.btnReportIssue.TabIndex = 0;
            this.btnReportIssue.Text = "&Report Issue";
            this.btnReportIssue.UseVisualStyleBackColor = true;
            this.btnReportIssue.Click += new System.EventHandler(this.btnReportIssue_Click);
            // 
            // btnDeveloperManagement
            // 
            this.btnDeveloperManagement.Location = new System.Drawing.Point(39, 158);
            this.btnDeveloperManagement.Name = "btnDeveloperManagement";
            this.btnDeveloperManagement.Size = new System.Drawing.Size(149, 51);
            this.btnDeveloperManagement.TabIndex = 1;
            this.btnDeveloperManagement.Text = "&Developer Management";
            this.btnDeveloperManagement.UseVisualStyleBackColor = true;
            this.btnDeveloperManagement.Click += new System.EventHandler(this.btnDeveloperManagement_Click);
            // 
            // btnResolveIssue
            // 
            this.btnResolveIssue.Location = new System.Drawing.Point(39, 252);
            this.btnResolveIssue.Name = "btnResolveIssue";
            this.btnResolveIssue.Size = new System.Drawing.Size(149, 51);
            this.btnResolveIssue.TabIndex = 2;
            this.btnResolveIssue.Text = "Resolve &Issue";
            this.btnResolveIssue.UseVisualStyleBackColor = true;
            this.btnResolveIssue.Click += new System.EventHandler(this.btnResolveIssue_Click);
            // 
            // ssMainForm
            // 
            this.ssMainForm.Location = new System.Drawing.Point(0, 428);
            this.ssMainForm.Name = "ssMainForm";
            this.ssMainForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssMainForm.Size = new System.Drawing.Size(711, 22);
            this.ssMainForm.TabIndex = 3;
            this.ssMainForm.Text = "Status";
            // 
            // lvResolutions
            // 
            this.lvResolutions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIssueTitle,
            this.colSeverity,
            this.colSolved,
            this.colDeveloperName});
            this.lvResolutions.ContextMenuStrip = this.cmsResolutions;
            this.lvResolutions.FullRowSelect = true;
            this.lvResolutions.GridLines = true;
            this.lvResolutions.HideSelection = false;
            this.lvResolutions.Location = new System.Drawing.Point(233, 66);
            this.lvResolutions.Name = "lvResolutions";
            this.lvResolutions.Size = new System.Drawing.Size(431, 237);
            this.lvResolutions.TabIndex = 4;
            this.lvResolutions.UseCompatibleStateImageBehavior = false;
            this.lvResolutions.View = System.Windows.Forms.View.Details;
            // 
            // colIssueTitle
            // 
            this.colIssueTitle.Text = "Issue Title";
            // 
            // colSeverity
            // 
            this.colSeverity.Text = "Severity";
            // 
            // colSolved
            // 
            this.colSolved.Text = "Solved";
            // 
            // colDeveloperName
            // 
            this.colDeveloperName.Text = "Developer Name";
            // 
            // cmsResolutions
            // 
            this.cmsResolutions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsResolutions.Name = "cmsResolutions";
            this.cmsResolutions.Size = new System.Drawing.Size(108, 48);
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.eToolStripMenuItem.Text = "Edit";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // generateReportToolStripMenuItem
            // 
            this.generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            this.generateReportToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.generateReportToolStripMenuItem.Text = "Generate Report";
            this.generateReportToolStripMenuItem.Click += new System.EventHandler(this.generateReportToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.lvResolutions);
            this.Controls.Add(this.ssMainForm);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnResolveIssue);
            this.Controls.Add(this.btnDeveloperManagement);
            this.Controls.Add(this.btnReportIssue);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.cmsResolutions.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportIssue;
        private System.Windows.Forms.Button btnDeveloperManagement;
        private System.Windows.Forms.Button btnResolveIssue;
        private System.Windows.Forms.StatusStrip ssMainForm;
        private System.Windows.Forms.ListView lvResolutions;
        private System.Windows.Forms.ColumnHeader colIssueTitle;
        private System.Windows.Forms.ColumnHeader colSeverity;
        private System.Windows.Forms.ColumnHeader colSolved;
        private System.Windows.Forms.ColumnHeader colDeveloperName;
        private System.Windows.Forms.ContextMenuStrip cmsResolutions;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportToolStripMenuItem;
    }
}

