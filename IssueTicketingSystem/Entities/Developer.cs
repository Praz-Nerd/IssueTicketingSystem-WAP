using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTicketingSystem.Entities
{
    public enum DeveloperPosition
    {
        INTERN, ENTRY, MID, SENIOR
    }

    [Serializable]
    public class Developer
    {
        public static int GlobalDCounter { get; set; } = 0;
        public int DeveloperId { get; set; }
        public string DeveloperName { get; set; }
        public DateTime HireDate { get; set; }
        public DeveloperPosition Position { get; set; }
        public string Email { get; set; }
        public Developer() 
        {
            DeveloperId = GlobalDCounter++;
            HireDate = DateTime.Now; 
        }

        public Developer(string developerName, DateTime hireDate, string email ,  DeveloperPosition position) : this()
        {
            DeveloperName = developerName;
            HireDate = hireDate;
            Position = position;
            Email = email;
        }

        public Developer(int id, string developerName, DateTime hireDate, string email, DeveloperPosition position) : this(developerName, hireDate, email, position) 
        { DeveloperId = id; }


        private static DeveloperPosition parsePosition(string posString)
        {
            DeveloperPosition position = DeveloperPosition.ENTRY;
            if (posString != null)
            {
                switch (posString.ToLower())
                {
                    case "intern": position = DeveloperPosition.INTERN; break;
                    case "entry": position = DeveloperPosition.ENTRY; break;
                    case "mid": position = DeveloperPosition.MID; break;
                    case "senior": position = DeveloperPosition.SENIOR; break;
                }
            }
            return position;
        }

        public static int getDeveloperIndex(int developerId, List<Developer> Developers)
        {
            for (int i = 0; i < Developers.Count; i++)
            {
                if (developerId == Developers[i].DeveloperId)
                { return i; }
            }
            return -1;
        }

        public static void updateId(List<Developer> Developers)
        {
            int newCounter = 0;
            foreach (Developer dev in Developers)
            {
                if(dev.DeveloperId >  newCounter)
                { newCounter = dev.DeveloperId; }
            }
            GlobalDCounter = newCounter+1;
        }
        //SQLite CRUD
        public static void ReloadTable(string connectionString, List<Developer> Developers)
        {
            //delete the whole table, then load all developers from the given list
            //updates db with data from a list, keeps ids instead of using the autoincrement
            string query = "DELETE FROM Developers;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();
            }
            foreach (var dev in Developers)
            {
                CreateDeveloper(connectionString, dev, true);
            }
        }
        public static void CreateDeveloper(string connectionString, Developer developer, bool keepId = false)
        {
            string query;
            if(keepId == false)
            {
                query = "INSERT INTO Developers (DeveloperName,HireDate,Position,Email) VALUES " +
                "(@DeveloperName,@HireDate,@Position,@Email);";
            }
            else
            {
                query = "INSERT INTO Developers (DeveloperId,DeveloperName,HireDate,Position,Email) VALUES " +
                "(@DeveloperId,@DeveloperName,@HireDate,@Position,@Email);";
            }
            
            using(SQLiteConnection connection =  new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@DeveloperName", developer.DeveloperName);
                command.Parameters.AddWithValue("@HireDate", developer.HireDate.ToString());
                command.Parameters.AddWithValue("@Position", developer.Position.ToString());
                command.Parameters.AddWithValue("@Email", developer.Email);
                if(keepId)
                {
                    command.Parameters.AddWithValue("@DeveloperId", developer.DeveloperId);
                }
                command.ExecuteNonQuery();
            }
        }
        public static List<Developer> ReadFromDB(string connectionString)
        {
            List<Developer> list = new List<Developer>();
            string query = "SELECT * FROM Developers;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Developer developer = new Developer((int)(long)reader["DeveloperId"],
                            (string)reader["DeveloperName"], DateTime.Parse((string)reader["HireDate"]), 
                            (string)reader["Email"],
                            parsePosition((string)reader["Position"]));
                        list.Add(developer);
                    }
                }

            }
            return list;
        }
        public static void DeleteDeveloper(string connectionString, int id) 
        {
            string query = "DELETE FROM Developers WHERE DeveloperId=@DeveloperId;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@DeveloperId", id);
                command.ExecuteNonQuery();
            }
        }
        public static void UpdateDeveloper(string connectionString, Developer developer)
        {
            string query = "UPDATE Developers SET DeveloperName=@DeveloperName, HireDate=@HireDate, Position=@Position, Email=@Email " +
                "WHERE DeveloperId=@DeveloperId;";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@DeveloperName", developer.DeveloperName);
                command.Parameters.AddWithValue("@HireDate", developer.HireDate.ToString());
                command.Parameters.AddWithValue("@Position", developer.Position.ToString());
                command.Parameters.AddWithValue("@Email", developer.Email);
                command.Parameters.AddWithValue("@DeveloperId", developer.DeveloperId);
                command.ExecuteNonQuery();
            }
        }
    }
}
