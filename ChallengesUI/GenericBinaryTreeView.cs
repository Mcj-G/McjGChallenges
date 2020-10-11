using ChallengesUI.Helpers;
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
    public partial class GenericBinaryTreeView : Form
    {
        private GBTDataTypesList list = new GBTDataTypesList();

        public GenericBinaryTreeView()
        {
            InitializeComponent();
            DataTypeComboBox.DataSource = list.TypeNames;
            OrderingComboBox.DataSource = list.Order;
            OrderTypeComboBox.DataSource = list.OrderType;
        }

        private void BackToAllButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainView frm = new MainView();
            frm.ShowDialog();
            this.Close();
        }

        private void ShowDataButton_Click(object sender, EventArgs e)
        {

        }

        private void AddDataButton_Click(object sender, EventArgs e)
        {
            // INTEGER

            if (DataTypeComboBox.SelectedValue.ToString() == "integer")
            {
                if (int.TryParse(addDataTextBox.Text, out int num))
                {
                    if (list.IntegerList == null || list.IntegerList?.Count == 0)
                    {
                        list.IntegerList = new List<int>();
                        list.IntegerList.Add(num);
                    }
                    else
                    {
                        list.IntegerList.Add(num);
                    }

                    if (InsertDataListTextBox.Text.Length == 0)
                    {
                        InsertDataListTextBox.Text = $"{num}";
                        addDataTextBox.Text = string.Empty;
                    }
                    else
                    {
                        InsertDataListTextBox.Text = $"{ InsertDataListTextBox.Text }, { num }";
                        addDataTextBox.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Plase, enter correct integer.");
                }
            }

            // STRING

            if (DataTypeComboBox.SelectedValue.ToString() == "text")
            {
                if (addDataTextBox.Text != null && addDataTextBox.Text != "")
                {
                    if (list.StringList == null || list.StringList?.Count == 0)
                    {
                        list.StringList = new List<string>();
                        list.StringList.Add(addDataTextBox.Text);
                    }
                    else
                    {
                        list.StringList.Add(addDataTextBox.Text);
                    }

                    if (InsertDataListTextBox.Text.Length == 0)
                    {
                        InsertDataListTextBox.Text = addDataTextBox.Text;
                        addDataTextBox.Text = string.Empty;
                    }
                    else
                    {
                        InsertDataListTextBox.Text = $"{ InsertDataListTextBox.Text }, { addDataTextBox.Text }";
                        addDataTextBox.Text = string.Empty;
                    }
                }
            }

        }

        private void ShowTreeButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            list.IntegerList = new List<int>();
            list.StringList = new List<string>();
            InsertDataListTextBox.Text = string.Empty;
            ShowDataTextBox.Text = string.Empty;
        }

        private void DataTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DataTypeComboBox.SelectedValue.ToString() == "text")
            {
                TOSLabel.Visible = true;
                OrderTypeComboBox.Visible = true;
            }
            else
            {
                TOSLabel.Visible = false;
                OrderTypeComboBox.Visible = false;
            }

            ClearButton.PerformClick();
        }
    }
}
