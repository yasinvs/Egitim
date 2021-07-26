using System;

namespace Gun2.Ders1.KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safely - tip güvenliği
            /*
             * https://gokcedemirr.wordpress.com/2017/06/17/type-safe-nedir/
             * Type-Safety, “tür güvenliği” olarak çevirirsek yazılımda kullanılan bir terimdir. Tür güvenliği, derleyici derleme sırasında türleri doğrulayacak ve biz bir değişkene yanlış tür atamayı denersek hata vereceği anlamına gelir. Örneğin C#, C++, Java type-safe bir dildir. Java’da bir değişken tanımlamak istediğimizde o değişkenin hangi veri tipinde bir değişken olduğunu belirtmek zorundayız. Mesela  PHP, JavaScript ve diğer dynamic scripting dillerinde bu durum söz konusu değildir. JavaScript’de bir değişken tanımladığımızda bu değişkenlere bir tip atamak zorunda değiliz yani bir seferinde o değişkene sayı atayıp sonrasında aynı değişkene karakter atayabiliriz. 
            */

            // Do not repeat yourself - Kendini Tekrarlama

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;

            double dolarDun = 7.55;
            double dolarBugun = 7.55;



            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Eşittir butonu");
            }

            if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
