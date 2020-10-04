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
    public partial class AnagramView : Form
    {
        public AnagramView()
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
            TrueTextBox.BackColor = Color.Gray;
            FalseTexBox.BackColor = Color.Gray;

            if (needleTextBox.Text != null && needleTextBox.Text != ""
                && haystackTextBox.Text != null && haystackTextBox.Text != "")
            {
                string needle = needleTextBox.Text.ToLower();
                string haystack = haystackTextBox.Text.ToLower();
                string check = "";
                bool output = false;

                needle = String.Concat(needle.OrderBy(x => x));

                if (needle.Length == haystack.Length)
                {
                    haystack = String.Concat(haystack.OrderBy(x => x));
                    if (needle == haystack)
                    {
                        output = true;
                    }
                }
                else if (needle.Length < haystack.Length)
                {
                    int length = haystack.Length - needle.Length;
                    for (int i = 0; i < length; i++)
                    {
                        check = String.Concat(haystack.Substring(i, needle.Length).OrderBy(x => x));

                        if (needle == check)
                        {
                            output = true;
                        }
                    }
                }

                if (output == true)
                {
                    TrueTextBox.BackColor = Color.Green;
                }
                else
                {
                    FalseTexBox.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Please, enter walues to Needle and Haystack");
            }
        }

        private void needleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void haystackTextBox_KeyDown(object sender, KeyEventArgs e)
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
