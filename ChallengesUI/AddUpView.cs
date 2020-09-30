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
    public partial class AddUpView : Form
    {
        public AddUpView()
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

        private void AddNumberButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(newNumberTextBox.Text, out int num))
            {
                if (listTextBox.Text.Length == 0)
                {
                    listTextBox.Text = $"{num}";
                }
                else
                {
                    listTextBox.Text = $"{ listTextBox.Text }, { num }";
                }
            }
            else
            {
                MessageBox.Show("Please, enter an integer.");
            }
            TrueLabel.BackColor = Color.Gray;
            FalseLabel.BackColor = Color.Gray;
            newNumberTextBox.Text = String.Empty;
        }

        private void newNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddNumberButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            listTextBox.Text = String.Empty;
            TrueLabel.BackColor = Color.Gray;
            FalseLabel.BackColor = Color.Gray;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            TrueLabel.BackColor = Color.Gray;
            FalseLabel.BackColor = Color.Gray;
            if (int.TryParse(kTextBox.Text, out int k) && listTextBox.Text != null && listTextBox.Text != "")
            {
                string list = listTextBox.Text.Replace(" ", string.Empty);
                string[] stringNums = list.Split(',');
                int[] checkList = Array.ConvertAll(stringNums, x => int.Parse(x));
                bool check = false;


                foreach (int num in checkList)
                {
                    if (checkList.Contains(k - num))
                    {
                        TrueLabel.BackColor = Color.Green;
                        check = true;
                    }
                }
                if (check == false)
                {
                    FalseLabel.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Please, enter correct values.");
            }
        }

        private void kTextBox_KeyDown(object sender, KeyEventArgs e)
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
