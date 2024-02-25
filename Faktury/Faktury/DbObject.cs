using System.ComponentModel.DataAnnotations;

namespace Faktury
{
    public abstract class DbObject 
    {
        [Key]
        public abstract int NumerFaktury { get; set; }
        [Required]
        public virtual string Data { get; set; }
        [Required]
        public abstract string Kontrahent { get; set; }
    }
}