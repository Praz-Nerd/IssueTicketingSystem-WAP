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
            this.contextMenuStripIssues = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvIssues = new System.Windows.Forms.ListView();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDevelopers = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbSolution = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStripIssues.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripIssues
            // 
            this.contextMenuStripIssues.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripIssues.Name = "contextMenuStripIssues";
            this.contextMenuStripIssues.Size = new System.Drawing.Size(108, 70);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Issues";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Developer Assigned";
            // 
            // lvIssues
            // 
            this.lvIssues.ContextMenuStrip = this.contextMenuStripIssues;
            this.lvIssues.FullRowSelect = true;
            this.lvIssues.HideSelection = false;
            this.lvIssues.Location = new System.Drawing.Point(90, 53);
            this.lvIssues.Name = "lvIssues";
            this.lvIssues.Size = new System.Drawing.Size(148, 132);
            this.lvIssues.TabIndex = 4;
            this.lvIssues.UseCompatibleStateImageBehavior = false;
            this.lvIssues.View = System.Windows.Forms.View.List;
            this.lvIssues.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvIssues_MouseClick);
            // 
            // tbDescription
            // 
            this.tbDescription.AcceptsReturn = true;
            this.tbDescription.AcceptsTab = true;
            this.tbDescription.Location = new System.Drawing.Point(90, 191);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(261, 90);
            this.tbDescription.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // cbDevelopers
            // 
            this.cbDevelopers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevelopers.FormattingEnabled = true;
            this.cbDevelopers.Location = new System.Drawing.Point(370, 69);
            this.cbDevelopers.Name = "cbDevelopers";
            this.cbDevelopers.Size = new System.Drawing.Size(138, 21);
            this.cbDevelopers.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(667, 407);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(667, 436);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCompatibleTextRendering = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbSolution
            // 
            this.tbSolution.Location = new System.Drawing.Point(90, 325);
            this.tbSolution.Multiline = true;
            this.tbSolution.Name = "tbSolution";
            this.tbSolution.Size = new System.Drawing.Size(447, 134);
            this.tbSolution.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Solution";
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbYes.Location = new System.Drawing.Point(546, 341);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(42, 17);
            this.rbYes.TabIndex = 12;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbNo.Location = new System.Drawing.Point(546, 364);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(38, 17);
            this.rbNo.TabIndex = 13;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Issue Solved?";
            // 
            // ResolveIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 493);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSolution);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbDevelopers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lvIssues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResolveIssueForm";
            this.Text = "ResolveIssueForm";
            this.Load += new System.EventHandler(this.ResolveIssueForm_Load);
            this.contextMenuStripIssues.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripIssues;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ListView lvIssues;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDevelopers;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbSolution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label label5;
    }
}