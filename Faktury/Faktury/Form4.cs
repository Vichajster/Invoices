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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            using (var db = new FakturyDB())
            {
                ////zapis do 1 bazy
             
                int NrF = Convert.ToInt32(NumerFakturyTextBox.Text);
              
                var ElementdoUsuniecia = db.ListaFakturBaza.Where(f => f.NumerFaktury == NrF).FirstOrDefault();
                var ElementdoUsuniecia1 = db.FakturyBaza.Where(f => f.NumerFaktury == NrF).FirstOrDefault();
                if (ElementdoUsuniecia != null&& ElementdoUsuniecia1 != null)
                {
                    db.ListaFakturBaza.Remove(ElementdoUsuniecia);
                    db.FakturyBaza.Remove(ElementdoUsuniecia1);
                    
                    db.SaveChanges();
                }

              
                Close();
            }
        }

        private void ZamknijButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
