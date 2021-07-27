using System;
using System.Collections.Generic;

namespace Gun4.Odev4.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kaynak ; https://www.ismailgursoy.com.tr/generic-type-collections-generic-tipinde-koleksiyonlar/
            // Klasik tipli koleksiyon sınıfları içerisine aldıkları elemanların hepsini object türünde saklar. Ve bu durum performans kaybına sebep olur, çünkü boxing ve unboxing işlemleri yapılmaktadır.
            // Performans kaybının yanı sıra aynı zamanda tür güvenliği (type safety) ‘de klasik tip koleksiyonlarda söz konusu değildir. .NET 2.0 ile birlikte System.Collections.Generic isim alanında bütün koleksiyonların Generic tipli versiyonları mevcuttur. Bu sayede generic koleksiyonlar ile performans daha da arttırılmış ve tür güvenliği de sağlanmıştır.

            // İki farklı değer alabilen generic türüdür

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Bir");
            dictionary.Add(2, "İki");
            dictionary.Add(3, "Üç");

            Console.WriteLine(dictionary.Count);

        }
    }
}
