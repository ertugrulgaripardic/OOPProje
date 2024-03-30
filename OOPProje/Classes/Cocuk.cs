using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class Cocuk : Insan
    {
        public string sifat;
        public void adSoyadSifatYaz(string isim,string soyisim,string sifati)
        {
            Console.WriteLine(isim +" " +soyisim +" " +sifati);
        }
    }
}
