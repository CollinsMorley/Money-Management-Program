using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading.Tasks;

namespace _17._07._2014___AccountManagement
{
    class Print
    {
        private ExpenseTracker et;
        private int index = 0;

        public Print(ExpenseTracker e)
        {
            et = e;
        }

        public void PrintReport()
        {
            PrintDialog pd = new PrintDialog();

            PrintDocument pDoc = new PrintDocument();
            if (pd.ShowDialog() == DialogResult.OK)
            {
                pDoc.PrinterSettings = pd.PrinterSettings;
                pDoc.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                pDoc.Print();
            }
        }

        public void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            Font smallFont = new Font("Arial", 8);
            Font printFont = new Font("Arial", 10);
            Font headFont = new Font("Arial", 15);
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left - 50;
            float topMargin = ev.MarginBounds.Top - 75;

            // Calculate the number of lines per page.
            linesPerPage = (ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics));

            ev.Graphics.DrawString("Expense Report [ " + DateTime.Now + " ] ", smallFont, Brushes.Black,
                leftMargin + 5, topMargin, new StringFormat());

            yPos = topMargin + headFont.GetHeight(ev.Graphics);

            ev.Graphics.FillRectangle(Brushes.LightGray, 5, yPos - 2, (int)ev.PageBounds.Width - 10, (int)headFont.GetHeight(ev.Graphics) + 4);
            ev.Graphics.DrawString("Id", headFont, Brushes.Black,
               leftMargin, yPos, new StringFormat());
            ev.Graphics.DrawString("Type", headFont, Brushes.Black,
               leftMargin + 65, yPos, new StringFormat());
            ev.Graphics.DrawString("Date", headFont, Brushes.Black,
               leftMargin + 140, yPos, new StringFormat());
            ev.Graphics.DrawString("Description", headFont, Brushes.Black,
               leftMargin + 325, yPos, new StringFormat());
            ev.Graphics.DrawString("Amount", headFont, Brushes.Black,
               leftMargin + 650, yPos, new StringFormat());
            count++;

            // Iterate over the Data, printing each line. 
            while (count < linesPerPage && index < et.EXPS.Count)
            {
                yPos = topMargin + 5 + (count * printFont.GetHeight(ev.Graphics)) + (headFont.GetHeight(ev.Graphics) + 5);
                //Draw Bg
                if (count % 2 == 0)
                {
                    ev.Graphics.FillRectangle(Brushes.WhiteSmoke, 5, yPos, (int)ev.PageBounds.Width - 5, (int)printFont.GetHeight(ev.Graphics));
                }
                
                ev.Graphics.DrawString((index+1).ToString(), printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                ev.Graphics.DrawString(et.EXPS[index].Type, printFont, Brushes.Black,
                   leftMargin + 65, yPos, new StringFormat());
                ev.Graphics.DrawString(et.EXPS[index].Date, printFont, Brushes.Black,
                   leftMargin + 140, yPos, new StringFormat());
                ev.Graphics.DrawString(et.EXPS[index].Description, printFont, Brushes.Black,
                   leftMargin + 325, yPos, new StringFormat());

                if (et.EXPS[index].Amount < 0)
                {
                    ev.Graphics.DrawString(et.EXPS[index].Amount_S, printFont, Brushes.Black,
                       leftMargin + 641, yPos, new StringFormat());
                }
                else
                {
                    ev.Graphics.DrawString(et.EXPS[index].Amount_S, printFont, Brushes.Black,
                       leftMargin + 650, yPos, new StringFormat());
                }
                count++;
                index++;
            }

            if (index >= et.EXPS.Count)
            {
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics)) + 
                    (headFont.GetHeight(ev.Graphics) * 2) + 5;
                
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Far;

                ev.Graphics.DrawString("Balance: " + et.GetBalance(), headFont, Brushes.Black, ev.MarginBounds.Right, yPos, sf);
            }

            // If more lines exist, print another page. 
            if (index < et.EXPS.Count)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }


    }
}
