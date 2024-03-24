using OOPProje.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class Baba : Insan,IOzellik
    {
        public void oku(string adi)
        {
            Console.WriteLine(adi + " okuyor..");
        }

    }
}
