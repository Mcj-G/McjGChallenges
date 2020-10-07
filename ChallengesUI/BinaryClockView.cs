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
    public partial class BinaryClockView : Form
    {
        public BinaryClockView()
        {
            InitializeComponent();
        }

        private void BackToAllButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainView frm = new MainView();
            frm.ShowDialog();
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeTexBox.Text = DateTime.Now.ToLongTimeString();

            SetLeftClock(ConvertToBinaryTime(timeTexBox.Text));
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            SetRightClock(ConvertToBinaryTime(timePicker.Value.ToLongTimeString()));
        }

        private void SetLeftClock(string[] binaryTime)
        {
            leftHT1.BackColor = (binaryTime[0][3] == '1' ? Color.Green : Color.Gray);
            leftHT2.BackColor = (binaryTime[0][2] == '1' ? Color.Green : Color.Gray);
                                                      
            leftHU1.BackColor = (binaryTime[1][3] == '1' ? Color.Green : Color.Gray);
            leftHU2.BackColor = (binaryTime[1][2] == '1' ? Color.Green : Color.Gray);
            leftHU4.BackColor = (binaryTime[1][1] == '1' ? Color.Green : Color.Gray);
            leftHU8.BackColor = (binaryTime[1][0] == '1' ? Color.Green : Color.Gray);
                                                      
            leftMT1.BackColor = (binaryTime[2][3] == '1' ? Color.Green : Color.Gray);
            leftMT2.BackColor = (binaryTime[2][2] == '1' ? Color.Green : Color.Gray);
            leftMT4.BackColor = (binaryTime[2][1] == '1' ? Color.Green : Color.Gray);
                                                      
            leftMU1.BackColor = (binaryTime[3][3] == '1' ? Color.Green : Color.Gray);
            leftMU2.BackColor = (binaryTime[3][2] == '1' ? Color.Green : Color.Gray);
            leftMU4.BackColor = (binaryTime[3][1] == '1' ? Color.Green : Color.Gray);
            leftMU8.BackColor = (binaryTime[3][0] == '1' ? Color.Green : Color.Gray);
                                                      
            leftST1.BackColor = (binaryTime[4][3] == '1' ? Color.Green : Color.Gray);
            leftST2.BackColor = (binaryTime[4][2] == '1' ? Color.Green : Color.Gray);
            leftST4.BackColor = (binaryTime[4][1] == '1' ? Color.Green : Color.Gray);
                                                      
            leftSU1.BackColor = (binaryTime[5][3] == '1' ? Color.Green : Color.Gray);
            leftSU2.BackColor = (binaryTime[5][2] == '1' ? Color.Green : Color.Gray);
            leftSU4.BackColor = (binaryTime[5][1] == '1' ? Color.Green : Color.Gray);
            leftSU8.BackColor = (binaryTime[5][0] == '1' ? Color.Green : Color.Gray);
        }

        private void SetRightClock(string[] binaryTime)
        {
            rightHT1.BackColor = (binaryTime[0][3] == '1' ? Color.Green : Color.Gray);
            rightHT2.BackColor = (binaryTime[0][2] == '1' ? Color.Green : Color.Gray);
            
            rightHU1.BackColor = (binaryTime[1][3] == '1' ? Color.Green : Color.Gray);
            rightHU2.BackColor = (binaryTime[1][2] == '1' ? Color.Green : Color.Gray);
            rightHU4.BackColor = (binaryTime[1][1] == '1' ? Color.Green : Color.Gray);
            rightHU8.BackColor = (binaryTime[1][0] == '1' ? Color.Green : Color.Gray);
            
            rightMT1.BackColor = (binaryTime[2][3] == '1' ? Color.Green : Color.Gray);
            rightMT2.BackColor = (binaryTime[2][2] == '1' ? Color.Green : Color.Gray);
            rightMT4.BackColor = (binaryTime[2][1] == '1' ? Color.Green : Color.Gray);
            
            rightMU1.BackColor = (binaryTime[3][3] == '1' ? Color.Green : Color.Gray);
            rightMU2.BackColor = (binaryTime[3][2] == '1' ? Color.Green : Color.Gray);
            rightMU4.BackColor = (binaryTime[3][1] == '1' ? Color.Green : Color.Gray);
            rightMU8.BackColor = (binaryTime[3][0] == '1' ? Color.Green : Color.Gray);
            
            rightST1.BackColor = (binaryTime[4][3] == '1' ? Color.Green : Color.Gray);
            rightST2.BackColor = (binaryTime[4][2] == '1' ? Color.Green : Color.Gray);
            rightST4.BackColor = (binaryTime[4][1] == '1' ? Color.Green : Color.Gray);
            
            rightSU1.BackColor = (binaryTime[5][3] == '1' ? Color.Green : Color.Gray);
            rightSU2.BackColor = (binaryTime[5][2] == '1' ? Color.Green : Color.Gray);
            rightSU4.BackColor = (binaryTime[5][1] == '1' ? Color.Green : Color.Gray);
            rightSU8.BackColor = (binaryTime[5][0] == '1' ? Color.Green : Color.Gray);
        }


        private string[] ConvertToBinaryTime(string inputTime)
        {
            int[] time = inputTime.Where(char.IsDigit).Select(x => int.Parse(x.ToString())).ToArray();

            string[] output = new string[6];
            
            for (int i = 0; i < 6; i++)
            {
                output[i] = Convert.ToString(time[i], 2).PadLeft(4, '0');
            }

            return output;
        }

        private void ResetLeftClock()
        {
            leftHT1.BackColor = Color.Gray;
            leftHT2.BackColor = Color.Gray;

            leftHU1.BackColor = Color.Gray;
            leftHU2.BackColor = Color.Gray;
            leftHU4.BackColor = Color.Gray;
            leftHU8.BackColor = Color.Gray;

            leftMT1.BackColor = Color.Gray;
            leftMT2.BackColor = Color.Gray;
            leftMT4.BackColor = Color.Gray;

            leftMU1.BackColor = Color.Gray;
            leftMU2.BackColor = Color.Gray;
            leftMU4.BackColor = Color.Gray;
            leftMU8.BackColor = Color.Gray;

            leftST1.BackColor = Color.Gray;
            leftST2.BackColor = Color.Gray;
            leftST4.BackColor = Color.Gray;

            leftSU1.BackColor = Color.Gray;
            leftSU2.BackColor = Color.Gray;
            leftSU4.BackColor = Color.Gray;
            leftSU8.BackColor = Color.Gray;
        }

        private void ReserRightClock()
        {
            rightHT1.BackColor = Color.Gray;
            rightHT2.BackColor = Color.Gray;
            
            rightHU1.BackColor = Color.Gray;
            rightHU2.BackColor = Color.Gray;
            rightHU4.BackColor = Color.Gray;
            rightHU8.BackColor = Color.Gray;
            
            rightMT1.BackColor = Color.Gray;
            rightMT2.BackColor = Color.Gray;
            rightMT4.BackColor = Color.Gray;
            
            rightMU1.BackColor = Color.Gray;
            rightMU2.BackColor = Color.Gray;
            rightMU4.BackColor = Color.Gray;
            rightMU8.BackColor = Color.Gray;
            
            rightST1.BackColor = Color.Gray;
            rightST2.BackColor = Color.Gray;
            rightST4.BackColor = Color.Gray;
            
            rightSU1.BackColor = Color.Gray;
            rightSU2.BackColor = Color.Gray;
            rightSU4.BackColor = Color.Gray;
            rightSU8.BackColor = Color.Gray;
        }

        private void ShowHideButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "help")
                {
                    if (control.Visible == false)
                    {
                        control.Visible = true;
                    }
                    else
                    {
                        control.Visible = false;
                    }
                }
            }
        }
    }
}
