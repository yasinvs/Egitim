using System;

namespace Gun4.Odev2.Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir classı new yani yeni örneklendirdiğimizde çalışan tek seferlik bloktur.
            // Constructors method gibi çalışır ve her zaman boş bir şekilde biz görmesek dahi çalışırlar
            // Constructors - Yapıcı Blok

            Customer customer1 = new Customer() { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");
            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer // Özellik barındıran Class
    {
        // default constructors
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı");
        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

}