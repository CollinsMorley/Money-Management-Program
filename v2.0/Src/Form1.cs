/*
 * 
 *  TODO:
 *      Add filters
 *      Dynamic sizing
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            decimal amt = decimal.Parse(AmountDE.Text);
            string date = DateDE.Text;

            if (amt > 0)
                amt *= -1;

            et.AddExpense(amt, date, "Expense", DescriptionDE.Text);

            MessageBox.Show("Report of $"+amt+" expense on "+date+" added.", "Expense Added",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
            RefreshExpenseGrid();

            AmountE.Text = "";
            DescriptionE.Text = "";
            DateDE.Text = "";
        }

        private void DepositBtn(object sender, EventArgs e)
        {
            decimal amt = decimal.Parse(AmountDE.Text);
            string date = DateDE.Text;

            et.AddExpense(amt, date, "Deposit", DescriptionDE.Text);

            MessageBox.Show("Report of $" + amt + " deposit on " + date + " added.", "Expense Added",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
            RefreshExpenseGrid();

            AmountDE.Text = "";
            DescriptionDE.Text = "";
            DateDE.Text = "";
        }

        private void SaveEditBtn_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(ID_E.Text) - 1;
            decimal amt = decimal.Parse(AmountE.Text);
            string date = DateE.Text;

            et.UpdateExpense(index, amt, date, DescriptionE.Text);

            MessageBox.Show("Report of $" + amt + " on " + date + " edit saved.", "Changes Saved",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
            RefreshExpenseGrid();

            ID_E.Text = "";
            AmountE.Text = "";
            DescriptionE.Text = "";
            DateE.Text = "";

            EditItemPanel.Visible = false;
        }

        private void CancelEditBtn_Click(object sender, EventArgs e)
        {
            ID_E.Text = "";
            AmountE.Text = "";
            DescriptionE.Text = "";
            DateE.Text = "";

            EditItemPanel.Visible = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(ID_E.Text) - 1;
            DialogResult res = MessageBox.Show("Are you sure you want to delete this?", "Delete Entry",
                                                 MessageBoxButtons.OKCancel,
                                                 MessageBoxIcon.Exclamation);

            if (res == DialogResult.OK)
            {
                et.DeleteExpense(index);

                ID_E.Text = "";
                AmountE.Text = "";
                DescriptionE.Text = "";
                DateE.Text = "";

                EditItemPanel.Visible = false;

                RefreshExpenseGrid();
            }
            else
            {
                return;
            }
        }

        private void expenseGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int expenseIndex = e.RowIndex;
            Expense editingExpense = et.GetExpenseInfo(expenseIndex);

            ID_E.Text = (expenseIndex + 1).ToString();
            AmountE.Text = editingExpense.Amount.ToString();
            DescriptionE.Text = editingExpense.Description;
            DateE.Text = editingExpense.Date;

            EditItemPanel.Visible = true;
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

        public void RefreshExpenseGrid()
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (et.ioh.UnsavedChanges)
            {
                DialogResult res = MessageBox.Show("There are unsaved changes.  Save now?", "Unsaved Changes",
                                                MessageBoxButtons.YesNoCancel,
                                                MessageBoxIcon.Exclamation);

                if (res == DialogResult.Yes)
                {
                    //Save changes
                    et.ioh.SaveAsReportToFile();
                    et.CreateNew();
                }
                else if (res == DialogResult.No)
                {
                    //Don't save
                    et.CreateNew();
                }
                else
                {
                    //Cancel
                    return;
                }
            }
            else
            {
                et.CreateNew();
            } 
            RefreshExpenseGrid();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (et.ioh.UnsavedChanges)
            {
                DialogResult res = MessageBox.Show("There are unsaved changes.  Save now?", "Unsaved Changes",
                                                MessageBoxButtons.YesNoCancel,
                                                MessageBoxIcon.Exclamation);

                if (res == DialogResult.Yes)
                {
                    //Save changes
                    et.ioh.SaveAsReportToFile();
                    e.Cancel = false;
                }
                else if (res == DialogResult.No)
                {
                    //Don't save
                    e.Cancel = false;
                }
                else
                {
                    //Cancel
                    e.Cancel = true;
                    return;
                }
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltersForm ff = new FiltersForm(this, et);
            ff.Visible = true;
        }
    }
}
