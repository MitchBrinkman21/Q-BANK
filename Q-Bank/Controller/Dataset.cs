using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q_Bank.Model;

namespace Q_Bank.Controller
{
    interface Dataset
    {
        List<User> userList { get; set; }
        List<Account> accountList { get; set; }
        List<Transaction> transactionList { get; set; }
        List<Message> messageList { get; set; }
    }
}
