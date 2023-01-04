using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_TravelTrip.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public String KullainiciAdi { get; set; }
        public string Sifre { get; set; }
    }
}