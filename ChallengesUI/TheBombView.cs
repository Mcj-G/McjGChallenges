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
    public partial class TheBombView : Form
    {
        public TheBombView()
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
            string txt = inputTextBox.Text.ToLower();

            if (txt.Contains("bomb"))
            {
                outputTextBox.Text = "Duck!!!";
            }
            else
            {
                outputTextBox.Text = "There is no bomb, relax.";
            }
        }
    }
}
