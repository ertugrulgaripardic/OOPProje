using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProje.Classes
{
    public class Insan
    { //başlangıç scope
      //access modifiers dataType değişkenadi
      //global variable
        public string adi;
        public string soyadi;
        //tam sayısal 
        public int yas = 0;
        public double maas = 0.0;
        //true yada false 
        public bool cinsiyet = false;
        int a = 5;
        public static int boy;

        //metotlar 2 ye ayrılırlar
        //geriye değer döndüren ve geriye değer döndürmeyen şeklinde.
        //access modifiers metoddönüştipi metodadi() {   }
        public  void uyu(string isim,string soyisim)
        {
            adi = "ibrahim";
            Console.WriteLine(isim +" "+ soyisim+ " uyuyor...");
            a = 10;
        }

        public void ekranaYaz(string isim,string soyisim)
        {
            adi = "hakan";
             a = 5;
            Console.WriteLine("Kişinin adı : " + isim + " kişinin soyadı " + soyisim);
        }

        public int yasHesapla(int dogumYili)
        {
            int sonuc = 0;
            sonuc = DateTime.Now.Year - dogumYili;
            return sonuc;
        }

        public string mesajGoster(int yas)
        {
            string mesaj = "";
            if(yas >0 && yas<=18)
            {
                mesaj = "küçüksünüz";
            }
            else if (yas > 18 && yas <= 35)
            {
                mesaj = "gençsiniz";
            }
            else if (yas > 35 && yas <= 55)
            {
                mesaj = "yetişkinsiniz";
            }
            else if (yas > 55 && yas <= 75)
            {
                mesaj = "yaşlısınız";
            }
            else if (yas > 75 && yas <= 99)
            {
                mesaj = "çok yaşlısınız";
            }
            else
            {
                mesaj = " lütfen geçerli bir yıl yazınız.";
            }

            return mesaj;
        }

        //boş constructor 
        public Insan()
        {

        }

        //parametre alan constructor 
        public Insan(string adi,string soyadi)
        {
            this.adi = adi;
            this.soyadi = soyadi;
        }

        public Insan(string adi,string soyadi,int yas,double maas,bool cinsiyet)
        {
            this.adi = adi;
            this.soyadi = soyadi;
            this.yas = yas;
            this.maas = maas;
            this.cinsiyet = cinsiyet;
        }


    } //bitiş scope
}
