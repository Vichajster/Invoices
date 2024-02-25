using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktury
{
    public partial class Form3 : Form
    {
     

        public Form3()
        {
            
            InitializeComponent();
            
        }
      
        private void ZamknijButton_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void AcceptButton_Click(object sender, EventArgs e)
        {

            using (var db = new FakturyDB())
            {
                ////zapis do 1 bazy
                string K = KontrahentTextBox.Text;
                int NrF = Convert.ToInt32(NumerFakturyTextBox.Text);
                string D = DataTextBox.Text;
                string N = NazwaTowaruTextBox.Text;
                int ile = Convert.ToInt32(IloscSztukTextBox.Text);
                int C = Convert.ToInt32(CenaTextBox.Text);
                var fromDB = db.ListaFakturBaza.Where(f => f.NumerFaktury == NrF).FirstOrDefault();

                fromDB.NumerFaktury = NrF;
                fromDB.Data = D;
                fromDB.Kontrahent = K;
                ////Zapis do drugiej bazy
                var fromDB1 = db.FakturyBaza.Where(f => f.NumerFaktury == NrF).FirstOrDefault();
                fromDB1.NumerFaktury = NrF;
                fromDB1.Data = D;
                fromDB1.Kontrahent = K;
                fromDB1.Nazwa = N;
                fromDB1.IlośćSztuk = ile;
                fromDB1.Cena = C;

                db.SaveChanges();
                Close();
            } 
            }
        }
    }

