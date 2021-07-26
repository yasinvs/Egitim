using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun3.Odev3.ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi : {0}", customer.Name);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi : {0}", customer.Name);
        }

        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("****** Müşteri ******");
                Console.WriteLine("Müşteri ID : {0}", customer.Id);
                Console.WriteLine("Müşteri Kimlik No : {0}", customer.IdentificationNumber);
                Console.WriteLine("Müşteri Adı ve Soyadı : {0} {1}", customer.Name, customer.Surname);
                Console.WriteLine("Müşteri Ülkesi : {0}", customer.Country);
                Console.WriteLine("Müşteri Şehri : {0}", customer.City);
            }
        }
    }
}
