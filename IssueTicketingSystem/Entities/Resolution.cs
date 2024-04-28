using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTicketingSystem.Entities
{
    public class Resolution
    {
        private static int GlobalRCounter = 0;
        public int ResolutionId { get; set; }
        public string ResolutionDescription { get; set; }
        public DateTime ResolutionDate { get; set; }
        public bool IsSolved { get; set; }
        public Issue Issue { get; set; }
        public Developer Developer { get; set; }

        public Resolution() 
        { 
            ResolutionId = GlobalRCounter++;
            ResolutionDate = DateTime.Now; 
            Issue = null; Developer = null; 
        }
        public Resolution(string resolutionDescription, DateTime resolutionDate,bool solved, Issue issue, Developer developer) :this()
        {
            ResolutionDescription = resolutionDescription;
            ResolutionDate = resolutionDate;
            IsSolved = solved;
            Issue = issue;
            Developer = developer;
        }
    }
}
