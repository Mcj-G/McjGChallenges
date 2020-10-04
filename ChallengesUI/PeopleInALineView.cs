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
    public partial class PeopleInALineView : Form
    {
        public PeopleInALineView()
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

        private void CheckButton_Click(object sender, EventArgs e)
        {
            int x = (int)xSpaceUpDown.Value;
            int y = (int)ySpaceUpDown.Value;
            int people = (int)peopleUpDown.Value;
            List<int> line = new List<int>();
            List<string> lines = new List<string>();
            string output = string.Empty;
            outputTextBox.Text = string.Empty;

            if (x == 0 || y == 0 || people == 0)
            {
                outputTextBox.Text = "Zero!";
            }
            else if (x * y < people)
            {
                outputTextBox.Text = $"{ "XXX              XXX" }{ Environment.NewLine }{ "   overcrowded" }{ Environment.NewLine }{ "XXX              XXX" }";
            }
            else
            {
                for (int i = 1; i <= x * y; i++)
                {
                    if (i > people)
                    {
                        line.Add(0);
                    }
                    else
                    {
                        line.Add(i);
                    }
                    
                    if (i % x == 0)
                    {
                        if (lines.Count % 2 == 0)
                        {
                            lines.Add(String.Join(", ", line));
                            line = new List<int>();
                        }
                        else
                        {
                            line.Reverse();
                            lines.Add(String.Join(", ", line));
                            line = new List<int>();
                        }
                        
                    }
                }

                foreach (var l in lines)
                {
                    output = $"{ output }{ l }{ Environment.NewLine }";
                }

                outputTextBox.Text = output.TrimEnd();
            }
        }

        private void xSpaceUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            CheckEnter(e);
        }

        private void ySpaceUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            CheckEnter(e);
        }

        private void peopleUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            CheckEnter(e);
        }

        private void CheckEnter(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
