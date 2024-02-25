using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury
{
    public class ListaFaktur : DbObject
    {


        private int numerFaktury = 0;

        private string data = "";

        private string kontrahent = "";
        public override int NumerFaktury
        {
            get { return numerFaktury; }
            set { numerFaktury = value; }
        }
        public override string Data
        {
            get { return data; }
            set { data = value; }
        }
        public override string Kontrahent
        {
            get { return kontrahent; }
            set { kontrahent = value; }
        }
        public List<Faktura> Fakturki { get; set; }
    }
}
