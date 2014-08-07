using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17._07._2014___AccountManagement
{
    partial class FiltersForm : Form
    {
        private Form1 parent;
        private ExpenseTracker et;
        public FiltersForm(Form1 parent, ExpenseTracker et)
        {
            this.parent = parent;
            this.et = et;
            InitializeComponent();
        }

        private void ApplyFiltersBtn_Click(object sender, EventArgs e)
        {
            decimal amount = 0;
            AMOUNT_FILTERS fd = AMOUNT_FILTERS.NULL;
            string type = TYPE_I.Text;

            if (type == "All")
            {
                type = null;
            }

            if (AMOUNT_I.Text != "")
            {
                amount = decimal.Parse(AMOUNT_I.Text);
                fd = AMOUNT_FILTERS.NULL;


                if (LT_R.Checked)
                {
                    fd = AMOUNT_FILTERS.LTE;
                }
                else if (ET_R.Checked)
                {
                    fd = AMOUNT_FILTERS.ET;
                }
                else if (GT_R.Checked)
                {
                    fd = AMOUNT_FILTERS.GTE;
                }
                else
                {
                    fd = AMOUNT_FILTERS.NULL;
                    amount = 0;
                }
            }

            et.ApplyFilters(type, amount, fd);
            parent.RefreshExpenseGrid();
            Close();
        }

        private void ClearFiltersBtn_Click(object sender, EventArgs e)
        {
            et.ClearFilters();
            parent.RefreshExpenseGrid();
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
