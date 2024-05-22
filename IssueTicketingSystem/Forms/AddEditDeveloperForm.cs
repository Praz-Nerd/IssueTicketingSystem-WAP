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
    public partial class AddEditDeveloperForm : Form
    {
        public Developer developer;
        public AddEditDeveloperForm()
        {
            InitializeComponent();
        }

        private DeveloperPosition parsePosition()
        {
            DeveloperPosition position = DeveloperPosition.ENTRY;
            if(cbPosition.SelectedItem != null)
            {
                switch (cbPosition.SelectedItem.ToString())
                {
                    case "Intern": position = DeveloperPosition.INTERN; break;
                    case "Entry Level": position = DeveloperPosition.ENTRY; break;
                    case "Mid Level": position= DeveloperPosition.MID; break;
                    case "Senior": position = DeveloperPosition.SENIOR; break;
                }
            }
            return position;
        }

        private void AddEditDeveloperForm_Load(object sender, EventArgs e)
        {
            if(developer != null) 
            {
                tbName.Text = developer.DeveloperName;
                tbEmail.Text = developer.Email;
                dtpHireDate.Value = developer.HireDate;
                cbPosition.Text = developer.Position.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (developer != null)
            {
                developer.DeveloperName = tbName.Text;
                developer.Email = tbEmail.Text;
                developer.HireDate = dtpHireDate.Value;
                developer.Position = parsePosition();
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Invalid name");
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Invalid email");
            }
        }

        private void dtpHireDate_Validating(object sender, CancelEventArgs e)
        {
            if(dtpHireDate.Value > DateTime.Now)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpHireDate, "Invalid hire date");
            }
        }
    }
}
