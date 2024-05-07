using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTicketingSystem.Entities
{
    public class Resolution
    {
        public static int GlobalRCounter { get; set; } = 0;
        public int ResolutionId { get; set; }
        public string ResolutionDescription { get; set; }
        public DateTime ResolutionDate { get; set; }
        public bool IsSolved { get; set; }
        public int IssueId { get; set; }
        public int DeveloperId { get; set; }

        public Resolution() 
        { 
            ResolutionId = GlobalRCounter++;
            ResolutionDate = DateTime.Now; 
        }
        public Resolution(string resolutionDescription, bool solved, int issue, int developer) :this()
        {
            ResolutionDescription = resolutionDescription;
            IsSolved = solved;
            IssueId = issue;
            DeveloperId = developer;
        }
    }
}
