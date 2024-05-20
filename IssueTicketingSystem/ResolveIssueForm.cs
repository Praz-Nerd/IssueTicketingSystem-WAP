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

        private void writeTextBox()
        {
            //var pos = lvIssues.SelectedIndices[0];
            var pos = tscbIssues.SelectedIndex;
            string display = "Time: " + issues[pos].IssueDate.ToString() + Environment.NewLine +
                "Sender: " + issues[pos].SenderEmail + Environment.NewLine +
                "Title: " + issues[pos].IssueTitle + Environment.NewLine +
                "Severity: " + issues[pos].Severity + Environment.NewLine +
                "Description: " + issues[pos].Description;
            tbDescription.Text = display;
        }

        private void updateListView()
        {   
            //lvIssues.Items.Clear();
            tscbIssues.Items.Clear();
            foreach (var issue in issues)
            {
                //ListViewItem lvIssue = new ListViewItem(issue.IssueTitle + " " + issue.Severity.ToString());
                tscbIssues.Items.Add(issue.IssueTitle + " " + issue.Severity.ToString());
                //lvIssues.Items.Add(lvIssue);
            }
        }

        private void ResolveIssueForm_Load(object sender, EventArgs e)
        {
            updateListView();
            
            tscbDevelopers.Items.Clear();
            
            foreach (var developer in developers)
            {
                tscbDevelopers.Items.Add(developer.DeveloperName + " " + developer.Position.ToString());
                
            }
            if(resolution != null)
            {
                int posIssue = Issue.getIssueIndex(resolution.IssueId, issues);
                int posDeveloper = Developer.getDeveloperIndex(resolution.DeveloperId, developers);
                tbSolution.Text = resolution.ResolutionDescription;
                rbYes.Checked = resolution.IsSolved;
                //lvIssues.Items[posIssue].Selected = true;
                tscbDevelopers.SelectedIndex = posDeveloper;
                tscbIssues.SelectedIndex = posIssue;
                writeTextBox();
            }
        }

        private void cbIssues_MouseDoubleClick(object sender, MouseEventArgs e){}
        
        //VIEWING ISSUES HERE
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void lvIssues_MouseClick(object sender, MouseEventArgs e)
        {
            tbDescription.Clear();
            if (tscbIssues.SelectedIndex != -1 )
            {
                writeTextBox();
            }
        }

        private void tscbIssues_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDescription.Clear();
            if (tscbIssues.SelectedIndex != -1)
            {
                writeTextBox();
            }
        }
        //EDITING ISSUES
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tscbIssues.SelectedIndex != -1)
            {
                var pos = tscbIssues.SelectedIndex;
                ReportIssueForm form = new ReportIssueForm();
                form.Issue = issues[pos];
                if(form.ShowDialog() == DialogResult.OK)
                {
                    writeTextBox();
                    updateListView();
                }
            }
            else
            {
                MessageBox.Show("No issue selected", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //DELETING ISSUES
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tscbIssues.SelectedIndex != -1)
            {
                var pos = tscbIssues.SelectedIndex;
                var result = MessageBox.Show("Delete issue?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    issues.Remove(issues[pos]);
                    tbDescription.Clear();
                    updateListView();
                }
            }
            else
            {
                MessageBox.Show("No issue selected", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //SEND RESOLUTION BACK
        private void btnOK_Click(object sender, EventArgs e)
        {
            //var posIssue = lvIssues.SelectedIndices[0];
            var posIssue = tscbIssues.SelectedIndex;
            var posDeveloper = tscbDevelopers.SelectedIndex;
            if(resolution == null)
            {
                resolution = new Resolution(tbSolution.Text, rbYes.Checked, issues[posIssue].IssueId, developers[posDeveloper].DeveloperId);
            }
            else
            {
                resolution.ResolutionDescription = tbSolution.Text;
                resolution.IsSolved = rbYes.Checked;
                resolution.IssueId = issues[posIssue].IssueId;
                resolution.DeveloperId = developers[posDeveloper].DeveloperId;
            }
            
        }

        
    }
}
