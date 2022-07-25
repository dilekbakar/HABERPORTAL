using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortal.Data.Model
{
    [Table("Rol")]
    public class Rol
    {

        public int ID { get; set; }

        [Display(Name ="Rol Adı : ")]
        [MinLength(3,ErrorMessage ="En az 3 karakter girniz!"), MaxLength(150,ErrorMessage ="150 Karakterden fazla değer girmeyiniz!")]
        public string RolAdi { get; set; }
    }
}
