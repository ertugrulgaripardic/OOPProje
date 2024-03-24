using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class Matematik
    {

        //2 tane parametre alan ve geriye int tipinde değer dönen adı topla olan bir metod tanımı
        //overload method 
        public int topla(int sayi1,int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public int topla(int sayi1, int sayi2,int sayi3)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2+ sayi3;
            return sonuc;
        }

        public int topla(int sayi1, int sayi2, int sayi3,int sayi4)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2 + sayi3+sayi4;
            return sonuc;
        }

        public int cikar(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
