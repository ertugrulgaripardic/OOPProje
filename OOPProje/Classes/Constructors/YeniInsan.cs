using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Constructors
{
    public class YeniInsan
    {
        public Kafa kafa;
        public string adi;
        public string soyadi;

        public YeniInsan(Kafa kafa, string adi, string soyadi)
        {
            this.kafa = kafa;
            this.adi = adi;
            this.soyadi = soyadi;
        }   

        public void ekranaYaz()
        {
            Console.WriteLine("Randevu alanın adı : " + adi + " soyadi : " + soyadi +
                              " göz rengi : " + kafa.goz.renk +
                              " kulağı : " + kafa.kulak.sekil +
                              " burnu : " + kafa.burun.tip);
        }
    }
}
