// See https://aka.ms/new-console-template for more information


using OOPProje.Classes;
using OOPProje.Classes.Abstracts;
using OOPProje.Classes.Constructors;
using OOPProje.Classes.Constructors2;

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
Mudur mudur = new Mudur();
Programci programci = new Programci();
Stajyer stajyer = new Stajyer();

double toplamMaas = 0.0;

toplamMaas += genelMudur.maasinizNedir();
toplamMaas += mudur.maasinizNedir();
toplamMaas += programci.maasinizNedir();
toplamMaas += stajyer.maasinizNedir();

Console.WriteLine("Toplam maaş : " + toplamMaas);


OOPProje.Classes.Abstracts2.Bmw bmw2 = new OOPProje.Classes.Abstracts2.Bmw();
OOPProje.Classes.Abstracts2.Mercedes mercedes = new OOPProje.Classes.Abstracts2.Mercedes();
OOPProje.Classes.Abstracts2.Porche porche = new OOPProje.Classes.Abstracts2.Porche();

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