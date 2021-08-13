using Gun5.Odev5.OyunDemo.Classes;
using Gun5.Odev5.OyunDemo.Entities;
using System;
using System.Collections.Generic;

namespace Gun5.Odev5.OyunDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                IdentificationNo = "123456789012",
                FirstName = "Deneme",
                LastName = "Deneme",
                BirthDate = new DateTime(1992, 1, 1)
            };

            CustomerManager personManager = new CustomerManager(new CustomerCheckManager());
            personManager.SignUp(customer);

            List<Offer> offers = new List<Offer>();
            offers.Add(new Offer() { Id = 1, Name = "deneme", DiscountRate = 20 });

            OfferManager offerManager = new OfferManager();
            foreach (var offer in offers)
            {
                offerManager.Add(offer);
            }

            Order order = new Order() { Id = 1, CategoryId = 1, ProductName = "Call of Duty", Price = 100 };

            OrderManager orderManager = new OrderManager();
            orderManager.Order(customer, order, offers[0]);
        }
    }
}
