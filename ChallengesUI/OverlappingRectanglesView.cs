using ChallengesUI.PopUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengesUI
{
    public partial class OverlappingRectanglesView : Form
    {
        public OverlappingRectanglesView()
        {
            InitializeComponent();
        }

        public int[] AParams { get; set; }
        public int[] BParams { get; set; }

        private void BackToAllButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainView frm = new MainView();
            frm.ShowDialog();
            this.Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (DataIsValid())
            {
                int aX = Math.Max(AParams[0], BParams[0]);
                int bX = Math.Min(AParams[0] + AParams[2], BParams[0] + BParams[2]);
                int aY = Math.Max(AParams[1], BParams[1]);
                int bY = Math.Min(AParams[1] + AParams[3], BParams[1] + BParams[3]);

                if (bX >= aX && bY >= aY)
                {
                    int output = (bX - aX) * (bY - aY);
                    outputTextBox.Text = output.ToString();
                }
                else
                {
                    outputTextBox.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Please enter correct values: integers");
            }
        }

        private bool DataIsValid()
        {
            bool output = true;

            if (int.TryParse(aXTextBox.Text, out int aX) == false)
            {
                output = false;
            }
            if (int.TryParse(aYTextBox.Text, out int aY) == false)
            {
                output = false;
            }
            if (int.TryParse(aWidthTextBox.Text, out int aWidth) == false)
            {
                output = false;
            }
            if (int.TryParse(aHeightTextBox.Text, out int aHeight) == false)
            {
                output = false;
            }
            if (int.TryParse(bXTextBox.Text, out int bX) == false)
            {
                output = false;
            }
            if (int.TryParse(bYTextBox.Text, out int bY) == false)
            {
                output = false;
            }
            if (int.TryParse(bWidthTextBox.Text, out int bWidth) == false)
            {
                output = false;
            }
            if (int.TryParse(bHeightTextBox.Text, out int bHeight) == false)
            {
                output = false;
            }

            if (output == true)
            {
                int[] arrA = { aX, aY, aWidth, aHeight };
                AParams = arrA;
                int[] arrB = { bX, bY, bWidth, bHeight };
                BParams = arrB;
            }

            return output;
        }

        private void VisualizationButton_Click(object sender, EventArgs e)
        {
            if (DataIsValid())
            {
                int[] arrA = AParams;
                int[] arrB = BParams;
                OverlappingRectanglesVisualization frm = new OverlappingRectanglesVisualization(arrA, arrB);
                frm.Show(); 
            }
        }
    }
}
