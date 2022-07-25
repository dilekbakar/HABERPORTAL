using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortal.Data.Model
{
    [Table("Kullanici")]
    public class Kullanici
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50, ErrorMessage = "Lütfen 50 karakteri geçmeyiniz!")]
        [Display(Name = "Ad Soyad")]
        public string AdSoyad { get; set; }

        [Display(Name = "E Mail")]
        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Lütfen geçerli bir e-mail giriniz!")]
        public string EMail { get; set; }

        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [Required]
        [MaxLength(16, ErrorMessage = "En fazla 6 karakter olmalıdır!")]
        public string Sifre { get; set; }

        [Display(Name = "Kayıt Tarihi")]
        public DateTime KayitTarih { get; set; }

        [Display(Name = "Aktif")]
        public bool Aktif { get; set; }

        public virtual Rol Rol { get; set; }



    }
}
