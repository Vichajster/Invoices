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

    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        Form3 fr=new Form3();
        //Tutaj niedokończone wybieranie elementu
        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {            
            //Dodanie kilku rekordów jeśli taka baza jeszcze nie istnieje
            FakturyDB db = new FakturyDB();
            if (!db.Database.Exists())
            {
               

                db.FakturyBaza.Add(new Faktura { Kontrahent = "Alpha Industry", NumerFaktury =1, Data ="27 czerwca 2021", Nazwa ="Mysz Gamingowa", IlośćSztuk=4, Cena =412});
                db.FakturyBaza.Add(new Faktura { Kontrahent = "Beta Industry", NumerFaktury=2, Data = "4 maj 2021", Nazwa = "Monitor", IlośćSztuk = 1, Cena = 1470 });
                db.FakturyBaza.Add(new Faktura { Kontrahent = "Gamma Industry", NumerFaktury = 3, Data = "13 marzec 2021",Nazwa = "Płyta główna", IlośćSztuk = 2, Cena = 852 });
                db.FakturyBaza.Add(new Faktura { Kontrahent = "Echo Industry", NumerFaktury = 4, Data = "12 kwiecień 2021", Nazwa = "Procesor", IlośćSztuk = 3, Cena = 2257 });
                db.ListaFakturBaza.Add(new ListaFaktur { Kontrahent = "Alpha Industry", Data = "27 czerwca 2021", NumerFaktury = 1 });
                db.ListaFakturBaza.Add(new ListaFaktur { Kontrahent = "Beta Industry", Data = "4 maj 2021", NumerFaktury = 2 });
                db.ListaFakturBaza.Add(new ListaFaktur { Kontrahent = "Gamma Industry", Data = "13 marzec 2021", NumerFaktury = 3 });
                db.ListaFakturBaza.Add(new ListaFaktur { Kontrahent = "Echo Industry", Data = "12 kwiecień 2021", NumerFaktury = 4 });

                
                db.SaveChanges();
            }
            listaFakturBindingSource.DataSource = db.ListaFakturBaza.ToList();
        }

        private void DodajFakture_Click(object sender, EventArgs e)
        {
            Form2 document = new Form2();
            document.Show();

        }
     

        private void ZamknijButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void EdytujButton_Click(object sender, EventArgs e)
        {
            

            Form3 document = new Form3();
            document.Show();
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            Form4 document = new Form4();
            document.Show();
        }
    }
}
