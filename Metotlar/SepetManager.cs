using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Product product)
        {
            
            Console.WriteLine("Sepete eklendi:"+product.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi:" + urunAdi);
            Console.WriteLine("Sepete eklendi:" + aciklama);
            Console.WriteLine("Sepete eklendi:" + fiyat);
        }
    }
}
