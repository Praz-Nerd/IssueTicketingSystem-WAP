using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTicketingSystem.Entities
{
    public enum IssueSeverity
    {
        UNKNOWN, LOW, MEDIUM, HIGH
    }
    public class Issue
    {
        private static int GlobalICounter = 0;
        private int IssueId {  get; set; }
        private DateTime IssueDate { get; set; }
        private string Description { get; set; }
        private string SenderEmail { get; set; }
        private IssueSeverity Severity { get; set; }

        public Issue() 
        {
            IssueId = GlobalICounter++;
            IssueDate = DateTime.Now; 
        }
        public Issue(string senderEmail, string description, IssueSeverity severity):this()
        {
            Severity = severity;
            Description = description;
            SenderEmail = senderEmail;
        }
    }
}
