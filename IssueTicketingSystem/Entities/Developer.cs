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
    }
}
