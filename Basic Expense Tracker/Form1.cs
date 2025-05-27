using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Expense_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;
            string amountText = txtAmount.Text;
            DateTime date = dtpDate.Value;

            string expenseEntry = date.ToShortDateString()+" - "+description+" - "+amountText;
            lstExpenses.Items.Add(expenseEntry);
            txtDescription.Text = "";
            txtAmount.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDescription.Clear();
            txtAmount.Clear();
            dtpDate.Value = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstExpenses.SelectedIndex != -1)
            {
                lstExpenses.Items.RemoveAt(lstExpenses.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an expense to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
