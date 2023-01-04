using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MVC_TravelTrip.Models.Siniflar
{
    public class BlogYorum
    {
        //IEnumerable sayesinde bir view ile 1 den fazla tablodan değer çekilebilir
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
        public IEnumerable<Yorumlar> Deger2  { get; set; }
    }
}