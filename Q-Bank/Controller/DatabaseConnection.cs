using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Q_Bank.Model;

namespace Q_Bank.Controller
{
    class DatabaseConnection
    {
        public String databaseSource { get; private set; }
        public String databaseName { get; private set; }
        public String username { get; private set; }
        public String password { get; private set; }
        public int port { get; private set; }
        public short connectionStatus { get; private set; }
        public SqlConnection con { get; set; }
        public DatabaseConnection()
        {
            databaseSource = "FEIKO-LAPTOP\\SQLEXPRESS";
            databaseName = "Q_bank";
            username = "sa";
            password = "Feiko1337";
        }

        public void OpenConnection()
        {
            string connetionString = null;
            connetionString = "Data Source=" + databaseSource + ";Initial Catalog=" + databaseName + ";User ID=" + username + ";Password=" + password;
            con = new SqlConnection(connetionString);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        public void CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        public List<Transaction> TestQuery()
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
            return transactionList;
        }
    }
}
