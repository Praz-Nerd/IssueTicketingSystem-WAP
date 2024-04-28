﻿namespace IssueTicketingSystem
{
    partial class DeveloperManagementForm
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
            this.lvDevelopers = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHireDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDevelopers
            // 
            this.lvDevelopers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colHireDate,
            this.colEmail,
            this.colPosition});
            this.lvDevelopers.ContextMenuStrip = this.contextMenuStrip1;
            this.lvDevelopers.FullRowSelect = true;
            this.lvDevelopers.GridLines = true;
            this.lvDevelopers.HideSelection = false;
            this.lvDevelopers.Location = new System.Drawing.Point(47, 66);
            this.lvDevelopers.Name = "lvDevelopers";
            this.lvDevelopers.Size = new System.Drawing.Size(426, 318);
            this.lvDevelopers.TabIndex = 0;
            this.lvDevelopers.UseCompatibleStateImageBehavior = false;
            this.lvDevelopers.View = System.Windows.Forms.View.Details;
            this.lvDevelopers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvDevelopers_MouseDoubleClick);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            // 
            // colHireDate
            // 
            this.colHireDate.Text = "Hire Date";
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            // 
            // colPosition
            // 
            this.colPosition.Text = "Position";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DeveloperManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.lvDevelopers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DeveloperManagementForm";
            this.Text = "DeveloperManagementForm";
            this.Load += new System.EventHandler(this.DeveloperManagementForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDevelopers;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colHireDate;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colPosition;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    }
}