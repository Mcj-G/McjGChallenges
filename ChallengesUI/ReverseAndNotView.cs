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
    public partial class ReverseAndNotView : Form
    {
        public ReverseAndNotView()
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

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (inputTextBox.Text != null && inputTextBox.Text != "")
            {
                if (Int64.TryParse(inputTextBox.Text, out Int64 i) && i > 0)
                {
                    outputTextBox.Text = $"{ String.Concat(i.ToString().Reverse()) }{ i }";
                }
                else
                {
                    MessageBox.Show("Please, enter correct value: a non-negative integer");
                    inputTextBox.Text = "";
                    outputTextBox.Text = "";
                } 
            }
            else
            {
                outputTextBox.Text = "";
            }
        }
    }
}
