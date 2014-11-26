using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q_Bank
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Home();
        }

        private void Transaction()
        {
                      
        }

        private void Home()
        {
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }

        private void TransactionOverview()
        {

        }

        private void TransactionStatus()
        {

        }




        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Wil je afsluiten?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) 
            {
                Application.Exit();
            }   
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = tabControl1.SelectedIndex;
            switch (i)
            {
                case 0: 
                    Home();
                    break;
                case 1:
                    Transaction();
                    break;
                case 2:
                    TransactionOverview();
                    break;
                case 3:
                    TransactionStatus();
                    break;
                default:
                    Home();
                    break;
            }
        }


    }
}
