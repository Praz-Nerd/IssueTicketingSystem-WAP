using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTicketingSystem.TSysGraphics
{
    public class BarChartValue
    {
        public string Label {  get; set; }
        public int Value { get; set; }

        public BarChartValue(string label, int value)
        {
            Label = label;
            Value = value;
        }
    }
}
