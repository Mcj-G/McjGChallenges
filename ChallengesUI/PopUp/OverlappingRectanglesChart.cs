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
    public partial class OverlappingRectanglesChart : Form
    {
        public OverlappingRectanglesChart()
        {
            InitializeComponent();
            
            

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g;

            g = e.Graphics;

            Pen myPen1 = new Pen(Color.Black);
            myPen1.Width = 5;
            Pen myPen2 = new Pen(Color.Blue);
            myPen2.Width = 5;
            Pen myPen3 = new Pen(Color.Blue);
            myPen3.Width = 5;

            int x1 = 2 * 20 + 100;
            int y1 = 0 * 20 + 100;
            int w1 = 2 * 20;
            int h1 = 7 * 20;
            int x2 = 0 * 20 + 100;
            int y2 = 2 * 20 + 100;
            int w2 = 7 * 20;
            int h2 = 3 * 20;


            // TODO - figure it out

            g.DrawRectangle(myPen1, x1, y1, w1, h1);
            g.DrawRectangle(myPen2, x2, y2, w2, h2);
            g.DrawRectangle(myPen3, 0, 200, 600, 200);

        }
    }
}
