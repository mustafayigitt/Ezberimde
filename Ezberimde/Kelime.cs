using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezberimde
{
    public class Kelime
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; }
        public string Anlam { get; set; }
        public string Cumle { get; set; }
        public bool EzberDurum { get; set; }
    }
}
