using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengesUI.PopUp
{
    public partial class OverlappingRectanglesVisualization : Form
    {
        public OverlappingRectanglesVisualization(int[] arrA, int[] arrB)
        {
            InitializeComponent();
            AParams = arrA;
            BParams = arrB;
        }
        public int[] AParams { get; set; }
        public int[] BParams { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g;
            
            g = e.Graphics;

            Pen myPen1 = new Pen(Color.Black);
            myPen1.Width = 5;
            Pen myPen2 = new Pen(Color.Blue);
            myPen2.Width = 5;
            Pen myPen3 = new Pen(Color.Gray);
            myPen3.Width = 3;

            // TODO - mke it scaleable

            int x1 = AParams[0] * 20 + 400;
            int y1 = 400 - (AParams[1] + AParams[3]) * 20;
            int w1 = AParams[2] * 20;
            int h1 = AParams[3] * 20;

            int x2 = BParams[0] * 20 + 400;
            int y2 = 400 - (BParams[1] + BParams[3]) * 20;
            int w2 = BParams[2] * 20;
            int h2 = BParams[3] * 20;

            g.DrawLine(myPen3, 400, 0, 400, 800);
            g.DrawLine(myPen3, 0, 400, 800, 400);
            g.DrawRectangle(myPen1, x1, y1, w1, h1);
            g.DrawRectangle(myPen2, x2, y2, w2, h2);

        }
    }
}
