using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTicketingSystem.TSysGraphics
{
    public partial class HistogramControl : Control
    {
        private BarChartValue[] _data;
        public BarChartValue[] Data {
            get {  return _data; }
            set {
                _data = value;
                Invalidate();
            } 
        }

        public HistogramControl()
        {
            InitializeComponent();

            ResizeRedraw = true;

            Data = new[]
            {
                new BarChartValue("one", 1),
                new BarChartValue("two", 2),
                new BarChartValue("three", 3),
                new BarChartValue("four", 4)
            };
        }

        public HistogramControl(BarChartValue[] data)
        {
            InitializeComponent();
            ResizeRedraw = true;
            Data = data;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            
        }

        private void HistogramControl_Paint(object sender, PaintEventArgs e)
        {
            //get the drawing context
            Graphics graphics = e.Graphics;
            
            //get the drawing area
            Rectangle clipRectangle = e.ClipRectangle;

            //determine the width of the bars
            var barWidth = clipRectangle.Width / Data.Length;
            //compute the maximum bar height
            var maxBarHeight = clipRectangle.Height * 0.9;
            //compute the scaling factor based on the maximum value that we want to represent
            var scalingFactor = maxBarHeight / Data.Max(x => x.Value);

            Brush redBrush = new SolidBrush(Color.Red);

            for (int i = 0; i < Data.Length; i++)
            {
                var barHeight = Data[i].Value * scalingFactor;

                graphics.FillRectangle(
                    redBrush,
                    i * barWidth,
                    (float)(clipRectangle.Height - barHeight),
                    (float)(0.8 * barWidth),
                    (float)barHeight);

                float xpos = (i * barWidth);
                float ypos = (float)(clipRectangle.Height - barHeight - 20); // Position above the bar
                graphics.DrawString(Data[i].Label + " has " + Data[i].Value,
                    new Font(Font.FontFamily, 12), 
                    new SolidBrush(Color.Black),
                    xpos, ypos);
            }
        }
    }
}
