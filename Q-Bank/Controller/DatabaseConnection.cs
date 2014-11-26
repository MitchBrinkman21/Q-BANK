using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public DatabaseConnection()
        {
            databaseSource = "";
            databaseName = "";
            username = "sa";
            password = "";
        }

        public void OpenConnection()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=" + databaseSource + ";Initial Catalog=" + databaseName + ";User ID=" + username + ";Password=" + password;
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}
