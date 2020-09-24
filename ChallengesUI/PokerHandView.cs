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
    public partial class PokerHandView : Form
    {
        public PokerHandView()
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
    }
}
