using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
        public Issue(int issueId, DateTime issueDate, string issueTitle, string description, string senderEmail, IssueSeverity severity)
            :this(issueTitle, senderEmail, description, severity)
        {
            IssueId = issueId;
            IssueDate = issueDate;
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

        public static IssueSeverity parseSeverity(string severityString) 
        {
            IssueSeverity severity = IssueSeverity.UNKNOWN;
            switch (severityString.ToLower())
            {
                case "low": severity = IssueSeverity.LOW; break;
                case "medium": severity = IssueSeverity.MEDIUM; break;
                case "high": severity = IssueSeverity.HIGH; break;
            }
            return severity;
        }

        //SQLite CRUD
        public static void CreateIssue(string connectionString, Issue issue, bool keepId = false)
        {
            string query;
            if (keepId == false)
            {
                query = "INSERT INTO Issues (IssueDate,IssueTitle,IssueDescription,SenderEmail,IssueSeverity) VALUES " +
                "(@IssueDate,@IssueTitle,@IssueDescription,@SenderEmail,@IssueSeverity);";
            }
            else
            {
                query = "INSERT INTO Issues (IssueId,IssueDate,IssueTitle,IssueDescription,SenderEmail,IssueSeverity) VALUES " +
                "(@IssueId,@IssueDate,@IssueTitle,@IssueDescription,@SenderEmail,@IssueSeverity);";
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@IssueDate", issue.IssueDate);
                command.Parameters.AddWithValue("@IssueTitle", issue.IssueTitle);
                command.Parameters.AddWithValue("@IssueDescription", issue.Description);
                command.Parameters.AddWithValue("@SenderEmail", issue.SenderEmail);
                command.Parameters.AddWithValue("@IssueSeverity", issue.Severity.ToString());

                if (keepId)
                {
                    command.Parameters.AddWithValue("@IssueId", issue.IssueId);
                }
                command.ExecuteNonQuery();
            }
        }
        public static List<Issue> ReadFromDB(string connectionString)
        {
            List<Issue> list = new List<Issue>();
            string query = "SELECT * FROM Issues;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        Issue issue = new Issue((int)(long)reader["IssueId"], DateTime.Parse((string)reader["IssueDate"]),
                            (string)reader["IssueTitle"], (string)reader["IssueDescription"], (string)reader["SenderEmail"],
                            parseSeverity((string)reader["IssueSeverity"]));
                        list.Add(issue);
                    }
                }

            }
            return list;
        }
        public static void DeleteIssue(string connectionString, int id)
        {
            string query = "DELETE FROM Issues WHERE IssueId=@IssueId;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@IssueId", id);
                command.ExecuteNonQuery();
            }
        }
        public static void UpdateIssue(string connectionString, Issue issue)
        {
            string query = "UPDATE Issues SET IssueDate=@IssueDate, IssueTitle=@IssueTitle, IssueDescription=@IssueDescription, SenderEmail=@SenderEmail, IssueSeverity=@IssueSeverity " +
                "WHERE IssueId=@IssueId;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@IssueDate", issue.IssueDate);
                command.Parameters.AddWithValue("@IssueTitle", issue.IssueTitle);
                command.Parameters.AddWithValue("@IssueDescription", issue.Description);
                command.Parameters.AddWithValue("@SenderEmail", issue.SenderEmail);
                command.Parameters.AddWithValue("@IssueSeverity", issue.Severity.ToString());
                command.Parameters.AddWithValue("@IssueId", issue.IssueId);
                command.ExecuteNonQuery();
            }
        }
    }
}
