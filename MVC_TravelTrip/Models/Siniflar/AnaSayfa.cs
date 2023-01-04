﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_TravelTrip.Models.Siniflar
{
    public class AnaSayfa
    {

        //using System.ComponentModel.DataAnnotations; Eklenmeli
        [Key]

        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
    }
}