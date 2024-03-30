﻿using OOPProje.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class Bmw : Araba, IDenizdeYuz, IHavadaUc, ICokHizliGit
    {
        public void cokHizliGit(string marka)
        {
            Console.WriteLine(marka + " çok hizli gidiyor..");
        }

        public void denizdeYuz(string marka)
        {
            Console.WriteLine(marka + " çok hizli gidiyor..");
        }

        public void havadaUc(string marka)
        {
            Console.WriteLine(marka + " havada uçuyor..");
        }
    }
}
