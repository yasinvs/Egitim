using System;

namespace A1.Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Packages packages1 = new Packages();
            Packages packages2 = new Packages();
            Packages packages3 = new Packages();

            packages1.id = 1111;
            packages1.adi = "Deneme";
            packages1.soyadi = "deneme2";
            packages1.durum = 1.1;

            packages2.id = 2222;
            packages2.adi = "Deneme2";
            packages2.soyadi = "deneme3";
            packages2.durum = 2.2;

            packages3.id = 3333;
            packages3.adi = "Deneme3";
            packages3.soyadi = "deneme4";
            packages3.durum = 3.3;


            Packages[] packages = new Packages[] { packages1, packages2, packages3, 
                                    new Packages { id = 4444, adi = "yeni", soyadi = "soyadi", durum = 4.4},
                                    new Packages { id = 5555, adi = "yeni2", soyadi = "soyadi2", durum = 5.5} };

            Console.WriteLine("for başladı");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            for (int i = 0; i < packages.Length; i++)
            {
                Console.WriteLine(packages[i].id); 
                Console.WriteLine(packages[i].adi); 
                Console.WriteLine(packages[i].soyadi); 
                Console.WriteLine(packages[i].durum);
                Console.WriteLine("============");
            }

            Console.WriteLine("foreach başladı");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            foreach (var pack in packages)
            {
                Console.WriteLine(pack.id);
                Console.WriteLine(pack.adi);
                Console.WriteLine(pack.soyadi);
                Console.WriteLine(pack.durum);
                Console.WriteLine("============");
            }

            Console.WriteLine("PackagesManager başladı");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            PackagesManager packagesManager = new PackagesManager();
            packagesManager.Add(packages1);
        }
    }
}
