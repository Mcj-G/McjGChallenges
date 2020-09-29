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
    public partial class AlmostPalindromeView : Form
    {
        public AlmostPalindromeView()
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
            if (inputTexBox.Text != null && inputTexBox.Text != "")
            {
                string original = inputTexBox.Text.ToLower().Replace(" ", string.Empty);
                string reversed = String.Concat(original.Reverse());
                int counter = 0;
                if (original == reversed)
                {
                    outputTextBox.Text = "FALSE";
                    isPalindromeCheck.BackColor = Color.Green;
                }
                else
                {
                    for (int i = 0; i < original.Length; i++)
                    {
                        if (original[i] != reversed[i])
                        {
                            counter++;
                        }
                        if (counter > 2)
                        {
                            outputTextBox.Text = "FALSE";
                            isPalindromeCheck.BackColor = Color.Red;
                            break;
                        }
                    }
                    if (counter == 2)
                    {
                        outputTextBox.Text = "TRUE";
                        isPalindromeCheck.BackColor = Color.Red;
                    }
                    else
                    {
                        outputTextBox.Text = "FALSE";
                        isPalindromeCheck.BackColor = Color.Red;
                    }
                } 
            }
            else
            {
                MessageBox.Show("Please, first type some text.");
            }
        }

        private void inputTexBox_KeyDown(object sender, KeyEventArgs e)
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
