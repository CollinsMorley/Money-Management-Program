using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17._07._2014___AccountManagement
{
    public partial class Form1 : Form
    {
        private ExpenseTracker et = new ExpenseTracker();

        public Form1()
        {
            ExpenseTracker et = new ExpenseTracker();
            InitializeComponent();
            RefreshExpenseGrid();
        }

        private void AddExpenseBut_Click(object sender, EventArgs e)
        {
            decimal amt = decimal.Parse(Amount.Text);
            string date = Date.Text;

            if (amt > 0)
                amt *= -1;

            et.AddExpense(amt, date, "Expense", DescriptionE.Text);

            MessageBox.Show("Report of $"+amt+" expense on "+date+" added.", "Expense Added",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
            RefreshExpenseGrid();

            Amount.Text = "";
            DescriptionE.Text = "";
        }

        private void DepositBtn(object sender, EventArgs e)
        {
            decimal amt = decimal.Parse(AmountD.Text);
            string date = DateD.Text;

            et.AddExpense(amt, date, "Deposit", DescriptionD.Text);

            MessageBox.Show("Report of $" + amt + " deposit on " + date + " added.", "Expense Added",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
            RefreshExpenseGrid();

            AmountD.Text = "";
            DescriptionD.Text = "";
        }

        private void updateBalance()
        {
            CurBal.Text = "Current Balance: "+et.GetBalance();
        }

        private void ClearExpenseGrid()
        {
            expenseGrid.Rows.Clear();
            expenseGrid.Refresh();
        }

        private void RefreshExpenseGrid()
        {
            ClearExpenseGrid();

            updateBalance();
            List<string[]> rows = et.GetData();
            for (int i = 0; i < rows.Count; i++)
            {
                expenseGrid.Rows.Add(rows[i]);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            et.ioh.SaveAsReportToFile();
            RefreshExpenseGrid();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            et.ioh.SaveReportToFile();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            et.ioh.LoadReportFromFile();
            RefreshExpenseGrid();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            et.ioh.PrintReport();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
