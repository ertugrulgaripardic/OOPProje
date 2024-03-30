using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes.Collections
{
    public class Personel
    {
        private string adi;
        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        }

        private string soyadi;
        public string Soyadi
        {
            get { return soyadi; }
            set { soyadi = value; }
        }

        private double maas;
        public double Maas
        {
            get 
            { 
                return maas;
            }
            set {
                maas = value; 
            }
        }

        public Personel(string adi, string soyadi, double maas)        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.maas = maas;

       }     
    }
}
