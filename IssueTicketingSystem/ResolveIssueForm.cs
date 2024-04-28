using IssueTicketingSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTicketingSystem
{
    public partial class ResolveIssueForm : Form
    {
        public List<Issue> issues;
        public List<Developer> developers;
        public Resolution resolution;
        public ResolveIssueForm()
        {
            InitializeComponent();
        }

        private void ResolveIssueForm_Load(object sender, EventArgs e)
        {
            cbDevelopers.Items.Clear();
            cbIssues.Items.Clear();
            foreach (var issue in issues)
            {
                cbIssues.Items.Add(issue.IssueTitle + " " + issue.Severity.ToString());
            }
            foreach(var developer in developers)
            {
                cbDevelopers.Items.Add(developer.DeveloperName + " " + developer.Position.ToString());
            }
        }

        private void cbIssues_MouseDoubleClick(object sender, MouseEventArgs e){}

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbIssues.SelectedItem != null)
            {
                MessageBox.Show(issues[cbIssues.SelectedIndex].Description, 
                    issues[cbIssues.SelectedIndex].IssueTitle, MessageBoxButtons.OK);
            }
        }
    }
}
