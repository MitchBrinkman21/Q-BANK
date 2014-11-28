using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Q_Bank.Model;

namespace Q_Bank.Controller
{
    public class MainViewController: Dataset
    {
        public List<User> userList { get; set; }
        public List<Account> accountList { get; set; }
        public List<Transaction> transactionList { get; set; }
        public List<Q_Bank.Model.Message> messageList { get; set; }
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
            try { 
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
            catch (Exception ex)
            {
                MessageBox.Show("Error in getAllTransactions!");
            }
        }
        public void GetAllMessages()
        {

        }
        public void StartForm()
        {

        }
    }
}
