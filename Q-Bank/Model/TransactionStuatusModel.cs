using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q_Bank.Model
{
    class TransactionStuatusModel
    {
        public List<Label> uitvoerDatums { get; set; }
        public List<Label> tegenRekening { get; set; }
        public List<Label> omschrijving { get; set; }
        public List<Label> bedrag { get; set; }
        public List<Label> status { get; set; }
        public List<CheckBox> kies { get; set; }

        public TransactionStuatusModel()
        {
            uitvoerDatums = new List<Label>();
            tegenRekening = new List<Label>();
            omschrijving = new List<Label>();
            bedrag = new List<Label>();
            status = new List<Label>();
            kies = new List<CheckBox>();
        }
    }
}
