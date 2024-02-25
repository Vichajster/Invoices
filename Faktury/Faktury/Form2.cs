using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktury
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ZamknijButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            // Dodawanie Rekordów do bazy
            FakturyDB db = new FakturyDB();
            string K = KontrahentTextBox.Text;
            int NrF = Convert.ToInt32(NumerFakturyTextBox.Text);
            string D = DataTextBox.Text;
            string N = NazwaTowaruTextBox.Text;
            int ile = Convert.ToInt32(IloscSztukTextBox.Text);
            int C = Convert.ToInt32(CenaTextBox.Text);
            db.FakturyBaza.Add(new Faktura { Kontrahent = K, NumerFaktury = NrF, Data = D, Nazwa = N, IlośćSztuk =ile, Cena = C });
            db.ListaFakturBaza.Add(new ListaFaktur { Kontrahent = K, Data=D,NumerFaktury = NrF});
            db.SaveChanges();
            Close();
            
            
        }
    }
}
