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
    public partial class ReportIssueForm : Form
    {
        public Issue Issue;

        private IssueSeverity parseSeverity()
        {
            IssueSeverity severity = IssueSeverity.UNKNOWN;
            if(cbSeverity.SelectedItem!=null)
            {
                switch (cbSeverity.SelectedItem.ToString())
                {
                    case "Low":
                        severity = IssueSeverity.LOW; break;
                    case "Medium":
                        severity = IssueSeverity.MEDIUM; break;
                    case "High":
                        severity = IssueSeverity.HIGH; break;
                    default:
                        severity = IssueSeverity.UNKNOWN; break;
                }
            }
            return severity;
        }

        public ReportIssueForm()
        {
            InitializeComponent();
        }

        private void ReportIssueForm_Load(object sender, EventArgs e)
        {
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Issue = new Issue(tbEmail.Text, tbDescription.Text, parseSeverity());
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(tbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Invalid email");
            }
        }

        private void tbDescription_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbDescription.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbDescription, "Description cannot be empty");
            }
        }
    }
}
