using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Flow
    {
        public  int  Id  { get; set; }
        public int kurum_id { get; set; }
        public string nokta_kodu { get; set; }
        public string kurumadi { get; set; }
        public string noktaadi { get; set; }
        public int enerji { get; set; }
        public int basinc { get; set; }
        public int sıcaklik { get; set; }
        public DateTime olcumzamani { get; set; }
  
    }
}
