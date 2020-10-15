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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void TheBombButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TheBombView frm = new TheBombView();
            frm.ShowDialog();
            this.Close();
        }

        private void AddUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUpView frm = new AddUpView();
            frm.ShowDialog();
            this.Close();
        }

        private void PeopleInALineButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PeopleInALineView frm = new PeopleInALineView();
            frm.ShowDialog();
            this.Close();
        }

        private void ReverseAndNotButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReverseAndNotView frm = new ReverseAndNotView();
            frm.ShowDialog();
            this.Close();
        }

        private void StringIncrementerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StringIncrementerView frm = new StringIncrementerView();
            frm.ShowDialog();
            this.Close();
        }

        private void BinaryClockButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BinaryClockView frm = new BinaryClockView();
            frm.ShowDialog();
            this.Close();
        }

        private void OverlappingRectanglesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OverlappingRectanglesView frm = new OverlappingRectanglesView();
            frm.ShowDialog();
            this.Close();
        }

        private void PokerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PokerHandView frm = new PokerHandView();
            frm.ShowDialog();
            this.Close();
        }

        private void AnagramButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnagramView frm = new AnagramView();
            frm.ShowDialog();
            this.Close();
        }

        private void PalindromeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlmostPalindromeView frm = new AlmostPalindromeView();
            frm.ShowDialog();
            this.Close();
        }

        private void VendingMachineButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            VendingMachineView frm = new VendingMachineView();
            frm.ShowDialog();
            this.Close();
        }
    }
}
