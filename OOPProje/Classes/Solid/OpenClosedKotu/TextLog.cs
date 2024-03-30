using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Solid.OpenClosedKotu
{
    public class TextLog 
    {

        public bool TextKayit(string text)
        {
            //işlemler
            Console.WriteLine(text + " text dosyasına kaydedildi");
            return true;
        }
    }
}
