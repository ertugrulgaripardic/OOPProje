// See https://aka.ms/new-console-template for more information


using OOPProje;
using OOPProje.Classes;
using OOPProje.Classes.Abstracts;
using OOPProje.Classes.Collections;
using OOPProje.Classes.Constructors;
using OOPProje.Classes.Constructors2;
using OOPProje.Classes.Solid.OpenClosedIyi;
using OOPProje.Classes.Solid.OpenClosedKotu;
using System.Collections;

Console.WriteLine("Hello, World!");
Math.Cos(3.14);
//ClassIsmi nesneadi = new ClassIsmi();
Insan.boy = 180;

Insan i = new Insan();
i.adi = "ibrahim";
i.soyadi = "gökyar";
i.yas = 46;
i.maas = 3.14;
i.cinsiyet = true;
i.uyu("metin","yıldız");
i.uyu(i.adi,i.soyadi);
Console.WriteLine("Yaşınız : " +i.yasHesapla(1989));
int gelenYas = i.yasHesapla(1980);
Console.WriteLine(i.mesajGoster(gelenYas));

new Insan("hakan", "yılmaz");
new Insan("metin", "yılmaz", 33, 3.14, true);

Araba a = new Araba();
a.marka = "Bmw";
a.model = "X5";
a.kapiSayisi = 4;
a.pencereSayisi = 4;
a.git("Mercedes","XL");
a.git(a.marka,a.model);

Anne an = new Anne();
an.adi = "fahriye";
an.soyadi = "Gökyar";
an.yas = 70;
an.maas = 3.14;
an.cinsiyet = false;
an.ekranaYaz(an.adi, an.soyadi);
an.dinle(an.adi);
an.yaz(an.adi);

an.oku(an.adi);

Baba b = new Baba();
b.ekranaYaz("Kasım", "Gökyar");
b.oku("Kasım");

Cocuk c = new Cocuk();
c.ekranaYaz("ibrahim", "gökyar");


AkilliCocuk ak = new AkilliCocuk();
ak.adi = "Hakan";
ak.soyadi = "Yılmaz";
ak.sifat = "Akıllıdır";
ak.adSoyadSifatYaz(ak.adi, ak.soyadi, ak.sifat);
ak.askereGit(ak.adi);
ak.ehliyetAl(ak.adi);
ak.KlubeGit(ak.adi);

UsluCocuk us = new UsluCocuk();
us.adSoyadSifatYaz("Mehmet", "Yıldız", "Usludur");
us.askereGit("Mehmet");
us.ehliyetAl("Mehmet");

HiperAktifCocuk hp = new HiperAktifCocuk();
hp.ehliyetAl("hüseyin");

Bmw bwm = new Bmw();
bwm.markaModelYaz("Bmw", "X5");
bwm.havadaUc("bmw");
bwm.denizdeYuz("bmw");
bwm.cokHizliGit("bmw");

Mercedes m = new Mercedes();
m.markaModelYaz("Mercedes", "XL");
m.marka = "Mercedes";
m.cokHizliGit(m.marka);
m.denizdeYuz(m.marka);

Porche p = new Porche();
p.markaModelYaz("Porche", "Carrera");
p.havadaUc("porche");


Matematik mat = new Matematik();

//1. yöntem 
int gelenDeger = mat.topla(5, 5);
Console.WriteLine("Toplam : " + gelenDeger);

//2.yöntem 
Console.WriteLine("Toplam 2. yöntem : " + mat.topla(15, 15));


//Calisan calisan = new Calisan(); 

GenelMudur genelMudur = new GenelMudur();
genelMudur.adi = "hakan";
genelMudur.soyadi = "yılmaz";
genelMudur.departman = "genel müdür";
Mudur mudur = new Mudur();
mudur.adi = "metin";
mudur.soyadi = "yildiz";
mudur.departman = "mudur";
Programci programci = new Programci();
programci.adi = "ibrahim";
programci.soyadi = "gökyar";
programci.departman = "yazılım";
Stajyer stajyer = new Stajyer();
stajyer.adi = "necati";
stajyer.soyadi = "ateş";
stajyer.departman = "arge";

double toplamMaas = 0.0;

toplamMaas += genelMudur.maasinizNedir();
toplamMaas += mudur.maasinizNedir();
toplamMaas += programci.maasinizNedir();
toplamMaas += stajyer.maasinizNedir();

Console.WriteLine("Toplam maaş : " + toplamMaas);


OOPProje.Classes.Abstracts2.Bmw bmw2 = new OOPProje.Classes.Abstracts2.Bmw();
bmw2.marka = "bmw";
bmw2.model = "x5";
OOPProje.Classes.Abstracts2.Mercedes mercedes = new OOPProje.Classes.Abstracts2.Mercedes();
mercedes.marka = "mercedes";
mercedes.model = "xl";
OOPProje.Classes.Abstracts2.Porche porche = new OOPProje.Classes.Abstracts2.Porche();
porche.marka = "porche";
porche.model = "carrera";

double harcananBenzin = 0.0;
harcananBenzin += bmw2.harcananBenzinNedir();
harcananBenzin += mercedes.harcananBenzinNedir();
harcananBenzin += porche.harcananBenzinNedir();
Console.WriteLine("Harcanan toplam benzin : " + harcananBenzin+" litredir.");


Goz goz = new Goz("mavi");
Kulak kulak = new Kulak("geniş");
Burun burun = new Burun("hokka");
Kafa kafa = new Kafa(goz,kulak,burun);
YeniInsan yeni = new YeniInsan(kafa,"ibrahim","gökyar");
yeni.ekranaYaz();


Marka marka = new Marka("Bmw");
Model model = new Model("X5");
Kapi kapi = new Kapi(4);
Pencere pencere = new Pencere(4);
Kasa kasa = new Kasa(marka, model, kapi, pencere, "Sedan");
YeniAraba yeniAraba = new YeniAraba(kasa,2000000.0);
yeniAraba.siparisYaz();



//for(int i=0; i<10; i++)  {  }

for(int j=0; j<5; j++)
{
    Console.WriteLine("Merhaba Dünya");
}

//ayın türden verileri bir isim altında saklamamızı sağlarlar.

//1. yöntem //outofboundexception
string[] gunler = new string[7];
gunler[0] = "pazartesi";
gunler[1] = "salı";
gunler[2] = "çarşamba";
gunler[3] = "perşembe";
gunler[4] = "cuma";
gunler[5] = "cumartesi";
gunler[6] = "pazar";

for(int k=0; k<gunler.Length;k++)
{
    Console.WriteLine(gunler[k]);
}
//2. yöntem
int[] sayilar = {3,4,6,7,9,11,22,33,44,55,77,99,100,105};
int toplam = 0;
for(int z=0;z<sayilar.Length;z++)
{
    toplam = toplam + sayilar[z];
    //toplam += sayilar[z];
}
Console.WriteLine("Sayıların toplamı : " + toplam);


Calisan[] calisanlar = { genelMudur, mudur, programci, stajyer };
double toplamMaas2 = 0;
for(int x=0; x<calisanlar.Length;x++)
{
    toplamMaas2 += calisanlar[x].maasinizNedir();
    Console.WriteLine("Çalışanın adı : " + calisanlar[x].adi + " soyadı : " + calisanlar[x].soyadi + " departmanı : " + calisanlar[x].departman);
}
Console.WriteLine("çalışanların toplam maaşı : " + toplamMaas2+ " TL dir.");


OOPProje.Classes.Abstracts2.Araba[] arabalar = { bmw2, mercedes, porche };
double  harcananBenzin2 = 0;
for(int y=0; y<arabalar.Length;y++)
{
    Console.WriteLine("Arabanın markası : " + arabalar[y].marka + " modeli : " + arabalar[y].model + " harcadığı benzin : " + arabalar[y].harcananBenzinNedir());
    harcananBenzin2 += arabalar[y].harcananBenzinNedir();

}
Console.WriteLine("Harcanan toplam benzin 2 : " + harcananBenzin2+" litredir.");


string[] renkler = { "sarı", "kırmızı", "yeşil", "mavi", "beyaz" };
foreach(string r in renkler)
{
    Console.WriteLine(r);
}

int abc = Convert.ToInt32("35");
object o = abc;
int xyz = (int)o;


//generic liste
List<string> liste = new List<string>();
liste.Add("ibrahim");
liste.Add("hakan");
liste.Add("mehmet");
liste.Add("hüseyin");
liste.Add("metin");
liste.Insert(0, "mert");

List<int> sayilar2 = new List<int>();
sayilar2.Add(33);
sayilar2.Add(44);

if(liste.Contains("ibrahimz"))
{
    Console.WriteLine("ilgili kişi listede var");
}
else
{
    Console.WriteLine("ilgili kişi listede yok");
}
Console.WriteLine("listede : " + liste.Count + " kişi var");

foreach(object ob in liste)
{
    Console.WriteLine(ob);
}
liste.Remove("ibrahim");
liste.RemoveAt(0);
Console.WriteLine("listede kalan kişi :  " + liste.Count + " kişi var");
liste.Clear();

List<Personel> personelListesi = new List<Personel>();
Personel p1 = new Personel("hakan", "yılmaz", 15000.0);
Personel p2 = new Personel("metin", "yildiz", 20000.0);
personelListesi.Add(p1);
personelListesi.Add(p2);
personelListesi.Add(new Personel("Ali", "Kaya", 30000.0));
double personelMaasi = 0.0;
foreach(Personel personel in personelListesi)
{
    Console.WriteLine("Personelin adı : " + personel.Adi + " soyadı : " + personel.Soyadi + " maaşı : " + personel.Maas);
    personelMaasi += personel.Maas;
}

Console.WriteLine("Personellerin toplam maaşı : " + personelMaasi + " TL dir.");



List<OOPProje.Classes.Abstracts2.Araba> arabaListesi = new List<OOPProje.Classes.Abstracts2.Araba>();
arabaListesi.Add(bmw2);
arabaListesi.Add(mercedes);
arabaListesi.Add(porche);
foreach(OOPProje.Classes.Abstracts2.Araba ab in arabaListesi)
{
    Console.WriteLine("arabanın markası : " + ab.marka + " modeli : " + ab.model + " harcadığı benzin : " + ab.harcananBenzinNedir());
}



DbLog dbLog = new DbLog();
XmlLog xmlLog = new XmlLog();
Logger logger = new Logger(dbLog,xmlLog);
logger.LogKayit(LogType.Xml, "303 nolu hata kodu oluştu");



DbLogIyi dbLogIyi = new DbLogIyi();
XmlLogIyi xmlLogIyi = new XmlLogIyi();
TextLogIyi textLogIyi = new TextLogIyi();
LoggerIyi loggerIyi = new LoggerIyi(dbLogIyi);
string gelenMesaj = loggerIyi.LogKayit("305 nolu sipariş alındı");
Console.WriteLine(gelenMesaj);
