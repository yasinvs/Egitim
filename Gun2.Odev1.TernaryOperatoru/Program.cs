using System;

namespace Gun2.Odev4.TernaryOperatoru
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ternary Operatörü
            //bir değişkene, metoda, property' ye değer atarken eğerki bu değer şarta göre fark edecekse tek satırda bu şart kontrolünü yaparak duruma göre değeri döndürmemizi sağlayan bir kalıpsal operatördür.

            /* Kurallar
             * 1- Dönecekler değerler aynı türden olacak
             * 
             * EKSTRA UZAK BİR BİLGİ
             * C# 9.0 ile birlikte Polimorfizm kuralına göre birbirlerinden türeyen değerde artık desteklenmektedir.
             */
            bool medeniHal = false;
            string mesaj = medeniHal == true ? "Evlilere kampanya..." : "Bekarlara Kampanya...";
            Console.WriteLine(mesaj);
            #endregion
            #region Birden fazla condition uygulamak
            int yas = 25;
            //Yaşı; 25'den küçük olanlara A, 25 olanlara B ve 25'den büyük olanlara C değerini döndüren ternary operatörü oluşturalım
            string sonuc = yas < 25 ? "A" : (yas == 25 ? "B" : "C");
            Console.WriteLine(sonuc);
            #endregion

            #region Örnek 1
            //Kullanıcı tarafından girilen sayının aşağıdaki önergelere göre hesabını gerçekleştiren kodu geliştiriniz.
            // sayi < 3                     => sayi * 5
            // sayi > 3 && sayi < 9         => sayi * 3
            // sayi >= 9 && sayi % 2 == 0   => sayi * 10
            // sayi % 2 == 1                => sayi
            // hiçbiri değilse              => -1

            Console.WriteLine("Lütfen bir sayı giriniz : ");

            int sayi = int.Parse(Console.ReadLine());
            int sonuc1 = sayi < 3 ? sayi * 5 :
                        (sayi > 3 && sayi < 9 ? sayi * 3 :
                        (sayi >= 9 && sayi % 2 == 0 ? sayi * 10 :
                        (sayi % 2 == 1 ? sayi : -1)));

            Console.WriteLine("Sonuç : {0}", sonuc1);
            #endregion
            #region Örnek 2
            // Hava durumunu tutan string değişkenin değerine göre aeşağıdaki önergeleri uygulayan programı yazınız
            // "Yağmurlu" => "Şemsiye almalısın"
            // "Güneşli"  => "Bol bol d vitamini alman dileğiyle...
            // "Kapalı"   => "Yağmur yağabilir".

            Console.WriteLine("Girilecek Değerler : ");
            Console.WriteLine("// Yağmurlu");
            Console.WriteLine("// Güneşli");
            Console.WriteLine("// Kapalı");
            Console.WriteLine("Lütfen hava durumunu giriniz : ");
            string durum = Console.ReadLine();
            string durum1 = durum == "Yağmurlu" ? "Şemsiye almalısın" :
                            (durum == "Güneşli" ? "Bol bol d vitamini alman dileğiyle..." :
                            (durum == "Kapalı" ? "Yağmur yağabilir" : "Bilemiyorum"));

            Console.WriteLine(durum1);
            #endregion
        }
    }
}
