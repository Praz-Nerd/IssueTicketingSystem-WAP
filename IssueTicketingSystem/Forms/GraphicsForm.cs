using IssueTicketingSystem.TSysGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTicketingSystem.Forms
{
    public partial class GraphicsForm : Form
    {
        public BarChartValue[] data;
        public GraphicsForm(BarChartValue[] data)
        {
            this.data = new BarChartValue[data.Length];
            Array.Copy(data, this.data, data.Length);

            //hcDevelopers = new HistogramControl(data);
            InitializeComponent();
            HistogramControl histogram = new HistogramControl(this.data)
            {
                Location = new Point(12, 20),
                Size = new Size(776, 426)
            };
            this.Controls.Add(histogram);
        }
    }
}
