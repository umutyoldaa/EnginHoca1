// See https://aka.ms/new-console-template for more information
using OOP2;

Console.WriteLine("Hello, World!");
GercekMusteri musteri1=new GercekMusteri();
musteri1.MusteriNo = "1234";
musteri1.Id = 1; 
musteri1.Adi = "Emre";
musteri1.SoyAdi = "Koc";
musteri1.TcNo = " 2131231231";


//Tuzel musteri
TuzelMusteri musteri2=new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "1212";
musteri2.SirketAdi ="Kodlama.io";
musteri2.VergiNo = "1231231231";
Musteri musteri3 = new TuzelMusteri();
musteri3.Id = 1;
CustomerManager customerManager = new CustomerManager();
customerManager.Add(musteri3);


