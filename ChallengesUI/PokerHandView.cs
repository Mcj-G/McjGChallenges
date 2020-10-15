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

        private void Color_CheckedChanged(object sender, EventArgs e)
        {
            HeartsCheckBox.CheckedChanged -= Color_CheckedChanged;
            DiamondsCheckBox.CheckedChanged -= Color_CheckedChanged;
            ClubsCheckBox.CheckedChanged -= Color_CheckedChanged;
            SpadesCheckBox.CheckedChanged -= Color_CheckedChanged;

            string name = ((CheckBox)sender).Name;

            if (name == HeartsCheckBox.Name)
            {
                HeartsCheckBox.Checked = true;
                DiamondsCheckBox.Checked = false;
                ClubsCheckBox.Checked = false;
                SpadesCheckBox.Checked = false;
            }
            else if (name == DiamondsCheckBox.Name)
            {
                HeartsCheckBox.Checked = false;
                DiamondsCheckBox.Checked = true;
                ClubsCheckBox.Checked = false;
                SpadesCheckBox.Checked = false;
            }
            else if (name == ClubsCheckBox.Name)
            {
                HeartsCheckBox.Checked = false;
                DiamondsCheckBox.Checked = false;
                ClubsCheckBox.Checked = true;
                SpadesCheckBox.Checked = false;
            }
            else if (name == SpadesCheckBox.Name)
            {
                HeartsCheckBox.Checked = false;
                DiamondsCheckBox.Checked = false;
                ClubsCheckBox.Checked = false;
                SpadesCheckBox.Checked = true;
            }

            HeartsCheckBox.CheckedChanged += Color_CheckedChanged;
            DiamondsCheckBox.CheckedChanged += Color_CheckedChanged;
            ClubsCheckBox.CheckedChanged += Color_CheckedChanged;
            SpadesCheckBox.CheckedChanged += Color_CheckedChanged;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (CardsTextBox.Text.Count(c => c == ',') < 4)
            {
                MessageBox.Show("You are missing some cards.");
            }
            else
            {
                string[] cards = CardsTextBox.Text.Replace(" ", string.Empty).Split(',');

                ResultTextBox.Text = PokerHandRanking(cards);
            }
        }

        public static string PokerHandRanking(string[] hand)
        {
            // TODO - check and think about it!

            var r = hand.Select(c => new {
                Card = c,
                Type = c.Substring(c.Length - 1, 1),
                Number = (int)Enum.Parse(typeof(CardNumber), "_" + c.Substring(0, c.Length - 1))
            }).OrderByDescending(c => c.Number);

            var types = r.GroupBy(c => c.Type);
            var isStraight = !r.Select(c => c.Number).Where((cn, i) => cn != (r.First().Number - i)).Any();
            var g = r.GroupBy(c => c.Number);

            if (types.Count() == 1)
            {
                if (isStraight)
                {
                    if (r.First().Number == 14)
                        return "Royal Flush";
                    else
                        return "Straight Flush";
                }
                else
                    return "Flush";
            }
            else
            {
                if (isStraight)
                {
                    return "Straight";
                }
                else if (g.Count() == 2)
                {
                    if (g.Any(d => d.Count() == 3))
                        return "Full House";
                    else
                        return "Four of a Kind";
                }
                else if (g.Count() == 3 && g.Any(x => x.Count() == 3))
                {
                    return "Three of a Kind";
                }
                else if (g.Count(x => x.Count() == 2) == 2)
                    return "Two Pair";
                else if (g.Count(x => x.Count() == 2) == 1)
                    return "Pair";
                else
                    return "High Card";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CardsTextBox.Text = string.Empty;
            ResultTextBox.Text = string.Empty;
        }

        private void CardButton_Click(object sender, EventArgs e)
        {
            if (CardsTextBox.Text.Count(c => c == ',') < 4)
            {
                string card = ((Button)sender).Name.Replace("Button", string.Empty);
                string color = "";
                if (HeartsCheckBox.Checked == true)
                {
                    color = "h";
                }
                else if (DiamondsCheckBox.Checked == true)
                {
                    color = "d";
                }
                else if (ClubsCheckBox.Checked == true)
                {
                    color = "c";
                }
                else if (SpadesCheckBox.Checked == true)
                {
                    color = "s";
                }

                string cardSymbol = $"{ card }{ color }";

                if (!CardsTextBox.Text.Contains(cardSymbol))
                {
                    if (CardsTextBox.Text.Length == 0)
                    {
                        CardsTextBox.Text = $"{ cardSymbol }";
                    }
                    else
                    {
                        CardsTextBox.Text = $"{ CardsTextBox.Text }, { cardSymbol }";
                    }  
                }
                else
                {
                    MessageBox.Show("You have already this card in hand.");
                }
            }
            else
            {
                MessageBox.Show("You have a full hand of cards.");
            }

        }

        private enum CardNumber
        {
            _A = 14,
            _K = 13,
            _Q = 12,
            _J = 11,
            _10 = 10,
            _9 = 9,
            _8 = 8,
            _7 = 7,
            _6 = 6,
            _5 = 5,
            _4 = 4,
            _3 = 3,
            _2 = 2,
            _1 = 1
        }
    }
}
