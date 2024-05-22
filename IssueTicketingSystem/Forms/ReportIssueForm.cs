using IssueTicketingSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    case "low":
                        severity = IssueSeverity.LOW; break;
                    case "medium":
                        severity = IssueSeverity.MEDIUM; break;
                    case "high":
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
            if(Issue != null)
            {
                tbTitle.Text = Issue.IssueTitle;
                //etbDescription.Text = Issue.Description;
                etbDescription.setText(Issue.Description);
                tbEmail.Text = Issue.SenderEmail;
                cbSeverity.SelectedItem = Issue.Severity.ToString().ToLower();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!validateAll())
            {
                MessageBox.Show("The form contains errors!",
                    "Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if(Issue == null)
            {
                Issue = new Issue(tbTitle.Text.ToLower(), tbEmail.Text, etbDescription.getText(), parseSeverity());
            }
            else
            {
                Issue.IssueTitle = tbTitle.Text;
                Issue.Description = etbDescription.getText();
                Issue.SenderEmail = tbEmail.Text;
                Issue.Severity = parseSeverity();
            }
        }

        private bool validateAll() { return isValidEmail() && isVaildDescription() && isValidTitle(); }

        private bool isValidEmail()
        {
            return !String.IsNullOrEmpty(tbEmail.Text) &&
                new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$").IsMatch(tbEmail.Text);
        }

        private bool isVaildDescription()
        { return !String.IsNullOrEmpty(etbDescription.getText()); }

        private bool isValidTitle() 
        { return !String.IsNullOrEmpty(tbTitle.Text);}

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if(!isValidEmail())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Invalid email");
            }
        }

        //deprecated
        private void tbDescription_Validating(object sender, CancelEventArgs e)
        {
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            if (!isValidTitle())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbTitle, "Description cannot be empty");
            }
        }

        private void etbDescription_Validating(object sender, CancelEventArgs e)
        {
            if (!isVaildDescription())
            {
                e.Cancel = true;
                errorProvider1.SetError(etbDescription, "Description cannot be empty");
            }
        }
    }
}
