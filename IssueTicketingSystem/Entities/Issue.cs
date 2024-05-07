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
        public static int GlobalICounter { get; set; } = 0;
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
        public static int getIssueIndex(int issueId, List<Issue> Issues)
        {
            for (int i = 0; i < Issues.Count; i++)
            {
                if (issueId == Issues[i].IssueId)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
