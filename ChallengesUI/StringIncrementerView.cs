using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengesUI
{
    public partial class StringIncrementerView : Form
    {
        public StringIncrementerView()
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

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            string str = inputTexBox.Text;

            var match = Regex.Match(str, @"\d+$");

            if (match.Success == false)
            {
                outputTextBox.Text = $"{ str }{ 1 }";
            }
            else
            {
                var mg = match.Groups[0];
                outputTextBox.Text = $"{ str.Substring(0, mg.Index) }{ (int.Parse(mg.Value) + 1).ToString().PadLeft(mg.Value.Length, '0') }";
            }
        }

        private void inputTexBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IncrementButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        
    }
}
