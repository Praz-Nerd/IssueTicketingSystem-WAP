namespace IssueTicketingSystem
{
    partial class ResolveIssueForm
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
            this.cbIssues = new System.Windows.Forms.ComboBox();
            this.contextMenuStripIssues = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDevelopers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStripIssues.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbIssues
            // 
            this.cbIssues.ContextMenuStrip = this.contextMenuStripIssues;
            this.cbIssues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIssues.FormattingEnabled = true;
            this.cbIssues.Location = new System.Drawing.Point(79, 40);
            this.cbIssues.Name = "cbIssues";
            this.cbIssues.Size = new System.Drawing.Size(121, 21);
            this.cbIssues.TabIndex = 0;
            this.cbIssues.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cbIssues_MouseDoubleClick);
            // 
            // contextMenuStripIssues
            // 
            this.contextMenuStripIssues.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.contextMenuStripIssues.Name = "contextMenuStripIssues";
            this.contextMenuStripIssues.Size = new System.Drawing.Size(100, 26);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Issues";
            // 
            // cbDevelopers
            // 
            this.cbDevelopers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevelopers.FormattingEnabled = true;
            this.cbDevelopers.Location = new System.Drawing.Point(348, 39);
            this.cbDevelopers.Name = "cbDevelopers";
            this.cbDevelopers.Size = new System.Drawing.Size(121, 21);
            this.cbDevelopers.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Developers";
            // 
            // ResolveIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDevelopers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbIssues);
            this.Name = "ResolveIssueForm";
            this.Text = "ResolveIssueForm";
            this.Load += new System.EventHandler(this.ResolveIssueForm_Load);
            this.contextMenuStripIssues.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIssues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDevelopers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripIssues;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    }
}