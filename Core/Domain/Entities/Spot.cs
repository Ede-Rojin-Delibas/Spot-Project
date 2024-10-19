using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Domain.Entities
{
    public class Spot
    {
        public  string kapasite_adi{ get; set; }
        public  string lisans_no { get; set; }
        public string nokta_kodu { get; set; }
        public string kurumadi { get; set; }
        public string noktaadi { get; set; }
        public int kapasite { get; set; }
        public int fiyat{ get; set; }
        public  string donem_tur { get; set; }
        public  int  ay { get; set; }
        public int yil { get; set; }
        public int id{ get; set; }
        public  int kurum_id { get; set; }
    }
}