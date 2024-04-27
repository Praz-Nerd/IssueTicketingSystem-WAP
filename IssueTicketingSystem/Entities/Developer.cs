using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTicketingSystem.Entities
{
    public class Developer
    {
        private static int GlobalDCounter = 0;
        private int DeveloperId { get; set; }
        private string DeveloperName { get; set; }
        private DateTime HireDate { get; set; }

        public Developer() 
        {
            DeveloperId = GlobalDCounter++;
            HireDate = DateTime.Now; 
        }

        public Developer(int developerId, string developerName, DateTime hireDate):this()
        {
            DeveloperId = developerId;
            DeveloperName = developerName;
            HireDate = hireDate;
        }
    }
}
