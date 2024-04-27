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
        private int ResolutionId { get; set; }
        private string ResolutionDescription { get; set; }
        private DateTime ResolutionDate { get; set; }
        private Issue Issue { get; set; }
        private Developer Developer { get; set; }

        public Resolution() 
        { 
            ResolutionId = GlobalRCounter++;
            ResolutionDate = DateTime.Now; 
            Issue = null; Developer = null; 
        }
        public Resolution(int resolutionId, string resolutionDescription, DateTime resolutionDate, Issue issue, Developer developer) :this()
        {
            ResolutionId = resolutionId;
            ResolutionDescription = resolutionDescription;
            ResolutionDate = resolutionDate;
            Issue = issue;
            Developer = developer;
        }
    }
}
