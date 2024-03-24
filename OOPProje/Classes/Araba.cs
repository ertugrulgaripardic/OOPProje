using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class Araba
    {

        public string marka;
        public string model;
        public int kapiSayisi;
        public int pencereSayisi;


        public void git(string markasi,string modeli)
        {
            Console.WriteLine(markasi +" "+ modeli +" gidiyor..");
        }

        public void markaModelYaz(string markasi,string modeli)
        {
            Console.WriteLine("Arabanın markası : " + markasi+ " Modeli : " + modeli);
        }
    }
}
