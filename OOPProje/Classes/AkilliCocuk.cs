using OOPProje.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class AkilliCocuk : Cocuk, IAskereGit, IEhliyetAl, IKlubeGit
    {
        public void askereGit(string adi)
        {
            Console.WriteLine(adi + " askere gidiyor..");
        }

        public void ehliyetAl(string adi)
        {
            Console.WriteLine(adi + " ehliyet alıyor..");
        }

        public void KlubeGit(string adi)
        {
            Console.WriteLine(adi + " klube gidiyor..");
        }
    }
}
