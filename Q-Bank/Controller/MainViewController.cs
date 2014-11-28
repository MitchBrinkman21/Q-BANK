using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q_Bank.Model;
using System.Data.SqlClient;

namespace Q_Bank.Controller
{
    class MainViewController: Dataset
    {
        public List<User> userList { get; set; }
        public List<Account> accountList { get; set; }
        public List<Transaction> transactionList { get; set; }
        public List<Message> messageList { get; set; }
        public SqlConnection con { get; set; }
        public MainViewController(SqlConnection con)
        {
            this.con = con;
        }
        public void GetAllUsers()
        {

        }
        public void GetAllAccounts()
        {

        }
        public void GetAllTransactions()
        {
            List<Transaction> transactionList = new List<Transaction>();
            String query = "SELECT * FROM Q_bank.dbo.[transaction]";
            SqlCommand newQuery = new SqlCommand(query, con);
            SqlDataReader myReader = null;

            myReader = newQuery.ExecuteReader();
            while (myReader.Read())
            {
                Transaction t = new Transaction();
                t.Amount = Convert.ToDouble(myReader["amount"]);
                t.DateTime = Convert.ToDateTime(myReader["datetime"]);
                t.Commit = Convert.ToBoolean(myReader["commit"]);
                t.ExecuteDateTime = Convert.ToDateTime(myReader["executeDateTime"]);
                t.NameReceiver = Convert.ToString(myReader["nameReceiver"]);
                t.IbanReceiver = Convert.ToString(myReader["ibanReceiver"]);
                transactionList.Add(t);
            }
            this.transactionList = transactionList;
        }
        public void GetAllMessages()
        {

        }
        public void StartForm()
        {

        }
    }
}
