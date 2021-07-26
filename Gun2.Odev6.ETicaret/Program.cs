using System;

namespace Gun2.Odev6.ETicaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "DELL Inspiron";
            urun1.Tipi = "Bilgisayar";
            urun1.Aciklama = "Dizüstü";
            urun1.Fiyati = 10.000;

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Arzum X111";
            urun2.Tipi = "Ütü";
            urun2.Aciklama = "Güzel Ütü";
            urun2.Fiyati = 545;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            UrunManager urunManager = new UrunManager();
            urunManager.Listele(urunler);
        }
    }
}
