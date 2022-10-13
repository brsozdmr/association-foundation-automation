using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class dernek
    {
        public const int dernekaidat = 120;

        public string dernekAdi { get; set; }
        public int dernekuyesayisi { get; set; }

        public int dernekhesap { get; set; }

        public dernek(string _dernekAdi, int _dernekuyesayisi )
        {
            _dernekAdi = dernekAdi;
            _dernekuyesayisi = dernekuyesayisi;
            
        }
        public void aidatodeme(int dernekaidat)
        { dernekhesap += dernekaidat; }

        public void dernekgider(int dernekgider)
        {
            dernekhesap -= dernekgider;
        }
        public int hesapsorgu()
        {
            return dernekhesap;
        }

    }
}
