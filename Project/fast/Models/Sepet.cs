using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fast.Models
{
    public class Sepet
    {
        [Key]
        public int SepetID { get; set; }
        public string UserMail { get; set; }
        public string Sanatci { get; set; }
        public string UrunAd { get; set; }
        public int Price { get; set; }
        public int Adet { get; set; }

    }
}
