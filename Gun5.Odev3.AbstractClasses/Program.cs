using System;

namespace Gun5.Odev3.AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    abstract class MevzuatBase
    {
        protected MevzuatBase()
        {

        }

        public abstract void Degerlendir();

        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi");
        }
    }

    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A mevzuatına göre değerlendirildi");
        }
    }

    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B mevzuatına göre değerlendirildi");
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
