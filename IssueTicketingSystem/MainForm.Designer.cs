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
            this.btnReportIssue = new System.Windows.Forms.Button();
            this.btnDeveloperManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReportIssue
            // 
            this.btnReportIssue.Location = new System.Drawing.Point(99, 66);
            this.btnReportIssue.Name = "btnReportIssue";
            this.btnReportIssue.Size = new System.Drawing.Size(149, 51);
            this.btnReportIssue.TabIndex = 0;
            this.btnReportIssue.Text = "Report Issue";
            this.btnReportIssue.UseVisualStyleBackColor = true;
            this.btnReportIssue.Click += new System.EventHandler(this.btnReportIssue_Click);
            // 
            // btnDeveloperManagement
            // 
            this.btnDeveloperManagement.Location = new System.Drawing.Point(99, 158);
            this.btnDeveloperManagement.Name = "btnDeveloperManagement";
            this.btnDeveloperManagement.Size = new System.Drawing.Size(149, 51);
            this.btnDeveloperManagement.TabIndex = 1;
            this.btnDeveloperManagement.Text = "Developer Management";
            this.btnDeveloperManagement.UseVisualStyleBackColor = true;
            this.btnDeveloperManagement.Click += new System.EventHandler(this.btnDeveloperManagement_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.btnDeveloperManagement);
            this.Controls.Add(this.btnReportIssue);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportIssue;
        private System.Windows.Forms.Button btnDeveloperManagement;
    }
}

