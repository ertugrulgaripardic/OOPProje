using OOPProje.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class Porche : Araba, IHavadaUc
    {
        public void havadaUc(string marka)
        {
            Console.WriteLine(marka + " havada uçuyor..");
        }
    }
}
