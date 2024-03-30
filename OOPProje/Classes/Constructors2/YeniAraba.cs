﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Constructors2
{
    public class YeniAraba
    {
        public Kasa kasa;
        public double fiyat;

        public YeniAraba(Kasa kasa, double fiyat)
        {
            this.kasa = kasa;
            this.fiyat = fiyat;
        }   

        public void siparisYaz()
        {
            Console.WriteLine("Arabanın markası : " + kasa.marka.markasi +
                              " modeli : " + kasa.model.modeli +
                              " kapı sayısı : " + kasa.kapi.kapiSayisi +
                              " pencere sayısı : " + kasa.pencere.pencereSayisi +
                              " kasası : " + kasa.kasaTipi +
                              " fiyatı : " + fiyat);
        }
    }
}
