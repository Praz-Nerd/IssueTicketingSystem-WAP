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
    public partial class MainForm : Form
    {
        public List<Issue> Issues;
        public List<Developer> Developers;
        public List<Resolution> Resolutions;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Issues = new List<Issue>();
            Developers = new List<Developer>();
            Resolutions = new List<Resolution>();
        }
        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            ReportIssueForm form = new ReportIssueForm();
            if(form.ShowDialog() == DialogResult.OK)
                Issues.Add(form.Issue);
        }

        private void btnDeveloperManagement_Click(object sender, EventArgs e)
        {
            DeveloperManagementForm form = new DeveloperManagementForm();
            form.developers = Developers;
            form.ShowDialog();
            
        }
    }
}
