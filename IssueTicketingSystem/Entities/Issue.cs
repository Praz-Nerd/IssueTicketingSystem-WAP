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
        public int IssueId {  get; set; }
        public DateTime IssueDate { get; set; }

        public string IssueTitle { get; set; }
        public string Description { get; set; }
        public string SenderEmail { get; set; }
        public IssueSeverity Severity { get; set; }

        public Issue() 
        {
            IssueId = GlobalICounter++;
            IssueDate = DateTime.Now; 
        }
        public Issue(string title, string senderEmail, string description, IssueSeverity severity):this()
        {
            IssueTitle = title;
            Severity = severity;
            Description = description;
            SenderEmail = senderEmail;
        }
    }
}
