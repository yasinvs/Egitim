using System;

namespace Gun2.Odev4.Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-5 arası rakam giriniz : ");
            int girilenSayi = int.Parse(Console.ReadLine());

            switch (girilenSayi)
            {
                case 1:
                    Console.WriteLine("Bir rakamı girildi");
                    break;
                case 2:
                    Console.WriteLine("İki rakamı girildi");
                    break;
                case 3:
                    Console.WriteLine("Üç rakamı girildi");
                    break;
                case 4:
                    Console.WriteLine("Dört rakamı girildi");
                    break;
                case 5:
                    Console.WriteLine("Beş rakamı girildi");
                    break;
                    
                default:
                    Console.WriteLine(girilenSayi + " girilen rakam aralık dışında");
                    break;
            }
        }
    }
}
