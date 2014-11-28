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
        public TabTransactionStatus(FormMain FormMain)
        {
            this.FormMain = FormMain;
            Label b = new Label();
            b.Text = "asdfesd";
            b.Anchor = AnchorStyles.Left;
            FormMain.TransactionStatusTableLayout.Controls.Add(b, 2, 5);
            //verwijderd de verticale scrollbar
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            FormMain.TransactionStatusTableLayout.Padding = new Padding(0, 0, vertScrollWidth, 0);
        }
    }
}
