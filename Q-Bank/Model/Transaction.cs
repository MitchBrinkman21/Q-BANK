using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_Bank.Model
{
    public class Transaction
    {
        public double Amount { get; set; }
        public DateTime DateTime { get; set; }
        public Boolean Commit { get; set; }
        public DateTime ExecuteDateTime { get; set; }
        public String NameReceiver { get; set; }
        public String IbanReceiver { get; set; }
        public override string ToString()
        {
            return "Amount: " + Amount + "\nDateTime: " + DateTime + "\nCommit: " + Commit + "\nExecuteDateTime: " + ExecuteDateTime + "\nNameReceiver: " + NameReceiver + "\nIbanReceiver: " + IbanReceiver;
        }
    }
}
