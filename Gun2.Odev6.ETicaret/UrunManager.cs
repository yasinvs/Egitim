using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun2.Odev6.ETicaret
{
    class UrunManager
    {
        public void Listele(Urun[] urunler)
        {
            Console.WriteLine("******************");
            Console.WriteLine("FOR döngüsü başladı...");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("--- Ürün {0} ---", urunler[i].Id);
                Console.WriteLine(urunler[i].Id);
                Console.WriteLine(urunler[i].Adi);
                Console.WriteLine(urunler[i].Tipi);
                Console.WriteLine(urunler[i].Aciklama);
                Console.WriteLine(urunler[i].Fiyati);
            }

            Console.WriteLine("******************");
            Console.WriteLine("FOREACH döngüsü başladı...");
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("--- Ürün {0} ---", urun.Id);
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Tipi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
            }

            Console.WriteLine("******************");
            Console.WriteLine("WHILE döngüsü başladı...");
            int urun1 = 0;
            while (urun1 < urunler.Length)
            {
                Console.WriteLine("--- Ürün {0} ---", urunler[urun1].Id);
                Console.WriteLine(urunler[urun1].Id);
                Console.WriteLine(urunler[urun1].Adi);
                Console.WriteLine(urunler[urun1].Tipi);
                Console.WriteLine(urunler[urun1].Aciklama);
                Console.WriteLine(urunler[urun1].Fiyati);
                urun1++;
            }
        }
    }
}
