using System;

namespace Gun3.Ders3.DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değer tipler
            /*
             * ramde sadece stack bölgede tutulurlar.
             * değer eşitlemesinden sonra değer değiştirilse.
             * diğer tipin değerine etki etmez.
             */
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30

            /////////////

            // Referans tipler
            /*
             * new ile heap bölgede örnek oluşturulur.
             * değer eşitlemesi yapılırsa.
             * eşitlenen birinci değerin referans numarası ramden düşer.
             * düşeni garbage collector denen çöp toplayıcı ramden siler.
             * böyle eşitlenenler tek referans numarasına bakar.
             * Örnek olarak sayilar1 = sayilar2 olursa 102' inci referans numarasına bakarlar
             */
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = 999;
             

        }
    }
}
