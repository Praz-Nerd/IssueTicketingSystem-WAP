using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTicketingSystem.Entities
{
    public enum DeveloperPosition
    {
        INTERN, ENTRY, MID, SENIOR
    }
    public class Developer
    {
        private static int GlobalDCounter = 0;
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
    }
}
