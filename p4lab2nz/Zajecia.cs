using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lab2nz
{
    //[Table("Wykłady")]

    public class Zajecia
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column("NazwaPrzedmiotu")]
        [MinLength(1)]
        public string Nazwa { get; set; }
        public string Sala { get; set; }
        public DateTime Godzina { get; set; }
        public int IloscObecnych { get; set; }

        public Zajecia()
        {

        }
    }
}
