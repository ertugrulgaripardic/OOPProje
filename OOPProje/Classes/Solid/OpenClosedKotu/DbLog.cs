using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Solid.OpenClosedKotu
{
    public class DbLog
    {

        public bool Kayit(string value)
        {
            //işlemler
            Console.WriteLine(value + " veritabanına kaydedildi");
            return true;
        }
    }
}
