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
    public partial class VendingMachineView : Form
    {
        public VendingMachineView()
        {
            InitializeComponent();

            DisplayTextBox.Text = "Insert a coin! Then select product.";
        }
        public decimal CoinAmount { get; set; }
        public string SelectedNumber { get; set; }

        private void NumButton_Click(object sender, EventArgs e)
        {
            if (CoinAmount > 0)
            {
                SelectedNumber = $"{ SelectedNumber }{ ((Button)sender).Text }";
                DisplayTextBox.Text = $"Selected product: nr.{ SelectedNumber }";
                
                if (SelectedNumber.Length == 2)
                {
                    DisplayTextBox.Text = $"Selected product: nr.{ SelectedNumber }";

                    if (int.Parse(SelectedNumber) > 0 && int.Parse(SelectedNumber) <= 16)
                    {
                        string stockName = $"Stock{ SelectedNumber }";
                        string priceTagName = $"PriceTag{ SelectedNumber }";
                        decimal productPrice = decimal.Parse(this.Controls[priceTagName].Text);

                        if (productPrice > CoinAmount)
                        {
                            DisplayTextBox.Text = "Sorry but this product costs more. Select again, toss more coins or return your money.";
                            SelectedNumber = string.Empty;
                        }
                        else
                        {
                            if (int.Parse(this.Controls[stockName].Text) > 0)
                            {
                                DisplayTextBox.Text = "Don't forget to take your rest and product!";
                                SelectedNumber = string.Empty;
                                RestTextBox.Text = (CoinAmount - productPrice).ToString("n");
                                CoinAmount = 0;
                                this.Controls[stockName].Text = (int.Parse(this.Controls[stockName].Text) - 1).ToString();
                                ProductTextBox.BackColor = this.Controls[stockName].BackColor; 
                            }
                            else
                            {
                                DisplayTextBox.Text = "This product has ended! Choose again";
                                SelectedNumber = string.Empty;
                            }
                        }
                    }
                    else
                    {
                        DisplayTextBox.Text = "There is no product with this number. Please, select again.";
                        SelectedNumber = string.Empty;
                    }
                }
            }
            else
            {
                DisplayTextBox.Text = "First insert a coin!";
            }
        }

        private void BackToAllButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainView frm = new MainView();
            frm.ShowDialog();
            this.Close();
        }

        private void CoinButton_Click(object sender, EventArgs e)
        {
            decimal amount = decimal.Parse(((Button)sender).Name.Replace("CoinButton", string.Empty));
            CoinAmount += amount / 100;
            DisplayTextBox.Text = $"Amount: {CoinAmount:n}. Select product.";
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            RestTextBox.Text = CoinAmount.ToString("n");
            CoinAmount = 0;
            DisplayTextBox.Text = "Insert a coin! Then choose product.";
        }

        private void TakeRestButton_Click(object sender, EventArgs e)
        {
            RestTextBox.Text = string.Empty;
            CoinAmount = 0;
            ProductTextBox.BackColor = Color.White;
            DisplayTextBox.Text = "Insert a coin! Then select product.";
        }

        private void RestockButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "Stock")
                {
                    control.Text = "5";
                }
            }
        }
    }
}
