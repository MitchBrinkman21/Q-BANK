using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q_Bank.View
{
    public class TabTransactionStatus
    {
        public FormMain FormMain { get; set; }
        private Model.TransactionStuatusModel tsm;
        public TabTransactionStatus(FormMain FormMain)
        {
            tsm = new Model.TransactionStuatusModel();
            this.FormMain = FormMain;

            FillTable();
            
            //verwijderd de verticale scrollbar
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            FormMain.TransactionStatusTableLayout.Padding = new Padding(0, 0, vertScrollWidth, 0);
        }

        private void FillTable()
        {
            tsm.tegenRekening.Clear();
            tsm.uitvoerDatums.Clear();
            for (int i = 0; i < 500; i++)
            {
                var temp = new Label();
                temp.Text = "01-12-2014";
                temp.Anchor = AnchorStyles.Left;
                FormMain.TransactionStatusTableLayout.Controls.Add(temp, 1, i + 2);
                tsm.uitvoerDatums.Add(temp);

                temp = new Label();
                temp.Text = "Belansingdienst NL86 INGB 0002 4455 88";
                temp.Anchor = AnchorStyles.Left;
                FormMain.TransactionStatusTableLayout.Controls.Add(temp, 2, i + 2);
                tsm.tegenRekening.Add(temp);
            }
        }
    }
}
