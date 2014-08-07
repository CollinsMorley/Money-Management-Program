using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _17._07._2014___AccountManagement
{
    public enum AMOUNT_FILTERS { NULL, LTE, ET, GTE };

    class Filters
    {
        public string type = null;
        public decimal amount = 0;
        public AMOUNT_FILTERS fd = AMOUNT_FILTERS.NULL;
    };

    class Expense
    {
        private decimal amount;
        private string description;
        private string date;
        private string type;

        public Expense(decimal amount, string date, string type, string description)
        {
            this.amount = amount;
            this.date = date;
            this.type = type;
            this.description = description;
        }

        public string Amount_S
        {
            get
            {
                if (amount < 0)
                    return "- $" + (amount * -1).ToString();
                else
                    return "$" + amount.ToString();
            }
        }
        public decimal Amount{
            get { return amount; }
            set { amount = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }

    class ExpenseTracker
    {
        public IOHandler ioh;

        private decimal balance = 0;
        private string fileName = "";
        private List<Expense> exps = new List<Expense>();

        private Filters activeFilter = null;

        public ExpenseTracker()
        {
            ioh = new IOHandler(this);
        }

        public void CreateNew()
        {
            exps.Clear();
            balance = 0;
            fileName = "";
            ioh = new IOHandler(this);
        }

        public void AddExpense(decimal amount, string date, string type, string description)
        {
            ioh.UnsavedChanges = true;
            balance += amount;
            Expense ex = new Expense(amount, date, type, description);
            exps.Add(ex);
        }

        public void UpdateExpense(int index, decimal amount, string date, string description)
        {
            if (index > exps.Count)
                return;

            string type = exps[index].Type;

            balance -= exps[index].Amount;

            ioh.UnsavedChanges = true;

            if (type == "Expense" && amount > 0)
            {
                amount *= -1;
            }
            balance += amount;

            exps[index] = new Expense(amount, date, type, description);
        }

        public void DeleteExpense(int index)
        {
            if (index > exps.Count)
                return;

            ioh.UnsavedChanges = true;
            exps.RemoveAt(index);
        }

        public void ApplyFilters(string type, decimal amount, AMOUNT_FILTERS filterDir)
        {
            activeFilter = new Filters();
            if (type != "All")
            {
                activeFilter.type = type;
            }

            if (filterDir != AMOUNT_FILTERS.NULL)
            {
                activeFilter.amount = amount;
                activeFilter.fd = filterDir;
            }
        }

        public void ClearFilters()
        {
            activeFilter = null;
        }

        public Expense GetExpenseInfo(int index)
        {
            return exps[index];
        }

        public string GetBalance()
        {
            if (balance < 0)
                return "-$" + (balance * -1).ToString();
            else
                return "$" + balance.ToString();
        }

        public List<string[]> GetData()
        {
            List<string[]> l = new List<string[]>();

            for (int i = 0; i < exps.Count; i++)
            {
                if (activeFilter != null)
                {
                    if (activeFilter.type != null)
                    {
                        if (exps[i].Type != activeFilter.type)
                        {
                            continue;
                        }
                    }

                    if (activeFilter.fd != AMOUNT_FILTERS.NULL)
                    {
                        switch (activeFilter.fd)
                        {
                            case AMOUNT_FILTERS.LTE:
                                if (exps[i].Amount > activeFilter.amount)
                                {
                                    continue;
                                }
                                break;
                            case AMOUNT_FILTERS.ET:
                                if (exps[i].Amount != activeFilter.amount)
                                {
                                    continue;
                                }
                                break;
                            case AMOUNT_FILTERS.GTE:
                                if (exps[i].Amount < activeFilter.amount)
                                {
                                    continue;
                                }
                                break;
                        }
                    }
                }

                string[] d = new string[5];
                d[0] = (i + 1).ToString();
                d[1] = exps[i].Date;
                d[2] = exps[i].Description;
                d[3] = exps[i].Type;
                d[4] = exps[i].Amount_S;

                l.Add(d);
            }

            return l;
        }

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public List<Expense> EXPS
        {
            get { return exps; }
        }
    }
}
