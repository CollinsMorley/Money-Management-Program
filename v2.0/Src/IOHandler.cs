using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _17._07._2014___AccountManagement
{
    class IOHandler
    {
        private ExpenseTracker et;
        private bool unsavedChanges = false;

        public IOHandler(ExpenseTracker e)
        {
            et = e;
        }

        public void PrintReport()
        {   
             Print p = new Print(et);;
             p.PrintReport();
        }

        public void LoadReportFromFile()
        {
            string line;

            OpenFileDialog openFromFile = new OpenFileDialog();

            openFromFile.Filter = "Tab Separated Values (*.tsv)|*.tsv|All files (*.*)|*.*";
            openFromFile.FilterIndex = 1;
            openFromFile.RestoreDirectory = true;

            if (openFromFile.ShowDialog() == DialogResult.OK) // Test result.
            {
                et.FileName = openFromFile.FileName;
                try
                {
                    StreamReader fin = new StreamReader(et.FileName);
                    while ((line = fin.ReadLine()) != null)
                    {
                        string[] token = line.Split('\t').ToArray<string>();
                        et.AddExpense(decimal.Parse(token[3]), token[0], token[2], token[1]);
                    }
                    fin.Close();
                    unsavedChanges = false;
                }
                catch (IOException e) { return; }

            }
        }

        public void SaveAsReportToFile()
        {
            SaveFileDialog saveAsTextDialogue = new SaveFileDialog();

            saveAsTextDialogue.FileName = "My Account Book";
            saveAsTextDialogue.DefaultExt = ".tsv";
            saveAsTextDialogue.Filter = "Tab Separated Values (*.tsv)|*.tsv|All files (*.*)|*.*";
            saveAsTextDialogue.FilterIndex = 1;
            saveAsTextDialogue.RestoreDirectory = true;

            if (saveAsTextDialogue.ShowDialog() == DialogResult.OK)
            {
                et.FileName = saveAsTextDialogue.FileName;
                using (StreamWriter fout = new StreamWriter(et.FileName))
                {
                    for (int i = 0; i < et.EXPS.Count; i++)
                    {
                        string data = et.EXPS[i].Date + "\t" + et.EXPS[i].Description + "\t" + et.EXPS[i].Type + "\t" + et.EXPS[i].Amount.ToString();
                        fout.WriteLine(data);
                    }
                    fout.Close();
                    unsavedChanges = false;
                }
            }
        }

        public void SaveReportToFile()
        {
            if (et.FileName == "")
            {
                SaveAsReportToFile();
            }
            else
            {
                using (StreamWriter fout = new StreamWriter(et.FileName))
                {
                    for (int i = 0; i < et.EXPS.Count; i++)
                    {
                        string data = et.EXPS[i].Date + "\t" + et.EXPS[i].Description + "\t" + et.EXPS[i].Type + "\t" + et.EXPS[i].Amount.ToString();
                        fout.WriteLine(data);
                    }
                    fout.Close();
                    unsavedChanges = false;
                }
            }
        }

        public bool UnsavedChanges
        {
            get { return unsavedChanges; }
            set { unsavedChanges = value; }
        }
    }
}
