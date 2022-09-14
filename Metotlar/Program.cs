// See https://aka.ms/new-console-template for more information
using Metotlar;

Console.WriteLine("Hello, World!");
Product urun = new Product();
urun.Adi = "Iphone";
urun.Fiyati = 15000;
urun.Aciklama = "Iphone 14 pro max";
Product[] urunler = new Product[] { urun };
foreach (Product item in urunler)
{
    Console.WriteLine(item.Adi);
    Console.WriteLine(item.Fiyati);
    Console.WriteLine(item.Aciklama);
}
SepetManager sepet = new SepetManager();
sepet.Ekle(urun);
sepet.Ekle2("armut", "yesil", 12.0, 10);
