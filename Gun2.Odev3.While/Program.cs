using System;

namespace Gun2.Odev4.While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 den büyük 100 dan küçük sayı giriniz : ");
            int girilenSayi = int.Parse(Console.ReadLine());

            while (girilenSayi <= 100)
            {
                Console.WriteLine(girilenSayi);

                girilenSayi--;
                if (girilenSayi == 0)
                {
                    break;
                }
            }
        }
    }
}
