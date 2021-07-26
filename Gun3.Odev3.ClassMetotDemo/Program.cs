using System;

namespace Gun3.Odev3.ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, IdentificationNumber = 1111111111, Name = "Selami", Surname = "Sekban", Country = "Turkey", City = "İstanbul" };
            Customer customer2 = new Customer() { Id = 2, IdentificationNumber = 222222222, Name = "Polat", Surname = "Alemdar", Country = "Turkey", City = "Ankara" };
            Customer customer3 = new Customer() { Id = 3, IdentificationNumber = 333333333, Name = "Michel", Surname = "Salon", Country = "England", City = "London" };

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);

            customerManager.List(customers);
        }
    }
}
