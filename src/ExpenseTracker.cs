using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _17._07._2014___AccountManagement
{
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

        public ExpenseTracker()
        {
            ioh = new IOHandler(this);
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

        public void AddExpense(decimal amount, string date, string type, string description)
        {
            balance += amount;
            Expense ex = new Expense(amount, date, type, description);
            exps.Add(ex);
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
    }
}
