using IssueTicketingSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTicketingSystem
{
    public partial class MainForm : Form
    {
        //connection string
        private const string DbConnection = "Data Source=TicketingDatabase.db";
        //lists with internal representation of data
        public List<Issue> Issues;
        public List<Developer> Developers;
        public List<Resolution> Resolutions;
        public MainForm()
        {
            InitializeComponent();
        }


        private void DisplayResolutions()
        {
            lvResolutions.Items.Clear();

            foreach (Resolution resolution in Resolutions)
            {
                int posIssue = Issue.getIssueIndex(resolution.IssueId, Issues);
                int posDeveloper = Developer.getDeveloperIndex(resolution.DeveloperId, Developers);
                ListViewItem item = new ListViewItem(Issues[posIssue].IssueTitle);
                item.SubItems.Add(Issues[posIssue].Severity.ToString());
                item.SubItems.Add(resolution.IsSolved.ToString());
                item.SubItems.Add(Developers[posDeveloper].DeveloperName);
                item.Tag = resolution;
                lvResolutions.Items.Add(item);
            }
        }

        private void UpdateStatusStrip()
        {
            ssMainForm.Items.Clear();
            ssMainForm.Items.Add(Issues.Count + " issues reported |");
            ssMainForm.Items.Add(Resolutions.Count + " resolutions |");
            ssMainForm.Items.Add(Developers.Count + " developers");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Issues = Issue.ReadFromDB(DbConnection);
            Developers = Developer.ReadFromDB(DbConnection);
            Resolutions = new List<Resolution>();
            UpdateStatusStrip();
            DisplayResolutions();
        }
        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            ReportIssueForm form = new ReportIssueForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                //Issues.Add(form.Issue);
                Issue.CreateIssue(DbConnection, form.Issue);
                Issues = Issue.ReadFromDB(DbConnection);
            }
                
            UpdateStatusStrip();
        }

        private void btnDeveloperManagement_Click(object sender, EventArgs e)
        {
            DeveloperManagementForm form = new DeveloperManagementForm();
            form.developers = Developers;
            form.ShowDialog();
            //send back the address, from deserialization
            Developers = form.developers;
            UpdateStatusStrip();
        }

        private void btnResolveIssue_Click(object sender, EventArgs e)
        {
            ResolveIssueForm form = new ResolveIssueForm();
            form.developers = Developers;
            form.issues = Issues;
            if(form.ShowDialog() == DialogResult.OK )
            {
                Resolutions.Add(form.resolution);
            }
            Issues = form.issues;
            UpdateStatusStrip();
            DisplayResolutions();
        }
        //EDITING AND DELETING ON LIST VIEW
        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvResolutions.SelectedItems.Count > 0)
            {
                ResolveIssueForm form = new ResolveIssueForm();
                form.issues = Issues;
                form.developers = Developers;
                form.resolution = lvResolutions.SelectedItems[0].Tag as Resolution;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DisplayResolutions();
                }
            }
            else
            {
                MessageBox.Show("No resolution selected", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvResolutions.SelectedItems.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete resolution?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Resolutions.Remove(lvResolutions.SelectedItems[0].Tag as Resolution);
                    DisplayResolutions();
                    UpdateStatusStrip();
                }
            }
            else
            {
                MessageBox.Show("No resolution selected", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //GENERATING TXT REPORT
        private string generateResolutionReport()
        {
            StringBuilder sb = new StringBuilder();
            int k = 0;
            foreach(Resolution resolution in Resolutions)
            {
                int posIssue = Issue.getIssueIndex(resolution.IssueId, Issues);
                int posDeveloper = Developer.getDeveloperIndex(resolution.DeveloperId, Developers);

                sb.AppendLine("Resolution No." + ++k + " at " + resolution.ResolutionDate);
                sb.AppendLine("Issue Title: " + Issues[posIssue].IssueTitle);
                sb.AppendLine("Issue Severity: " + Issues[posIssue].Severity.ToString());
                sb.AppendLine("\nIssue Description\n" + Issues[posIssue].Description);
                sb.AppendLine("\nIssue Solution\n" + resolution.ResolutionDescription);
                sb.AppendLine("\nSolved? " + resolution.IsSolved.ToString());
                sb.AppendLine("Developer Responsible: " + Developers[posDeveloper].DeveloperName);
                sb.AppendLine("- - - - - - - - - - - -");
            }
            return sb.ToString();
        }
        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Resolutions.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using(StreamWriter sw = File.CreateText(saveFileDialog.FileName))
                    {
                        sw.Write(generateResolutionReport());
                    }
                }
            }
            else
            {
                MessageBox.Show("No resolutions added", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
