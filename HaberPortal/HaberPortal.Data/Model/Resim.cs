using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortal.Data.Model
{
    [Table("Resim")]
    public class Resim
    {
        [Key]
        public int ID { get; set; }

        public string ResimURL { get; set; }

        public Haber Haber { get; set; }


    }
}
