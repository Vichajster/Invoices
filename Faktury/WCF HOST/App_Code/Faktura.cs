using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktury
{
   public  class Faktura :DbObject
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
        [MaxLength(80)]
        [Required]
        public string Nazwa { get; set; }
        [Required]
        public int IlośćSztuk { get; set; }
        [Required]
        public decimal Cena { get; set; }


        public ListaFaktur ListaFaktur { get; set; }
        [ForeignKey("ListaFaktur")]
        public int? ListaFakturId { get; set; }
       
    }
}
