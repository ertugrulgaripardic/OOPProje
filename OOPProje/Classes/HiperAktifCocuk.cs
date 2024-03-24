using OOPProje.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class HiperAktifCocuk : Cocuk, IEhliyetAl
    {
        public void ehliyetAl(string adi)
        {
            Console.WriteLine(adi + " ehliyet alıyor..");
        }
    }
}
