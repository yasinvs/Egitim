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
            Person person = Person();
            List<Offer> offers = Offer();
            Order(person, offers);
        }

        private static void Order(Person person, List<Offer> offers)
        {
            Order order = new Order() { Id = 1, ProductName = "Call of Duty" };

            OrderManager orderManager = new OrderManager();
            orderManager.Order(person, order, offers[0]);
        }

        private static List<Offer> Offer()
        {
            List<Offer> offers = new List<Offer>();
            offers.Add(new Offer() { Name = "deneme", DiscountRate = 20 });

            OfferManager offerManager = new OfferManager();
            foreach (var offer in offers)
            {
                offerManager.Add(offer);
            }
            return offers;
        }

        private static Person Person()
        {
            Person person = new Person()
            {
                IdentificationNo = "123456789012",
                FirstName = "Deneme",
                LastName = "Deneme",
                BirthDate = new DateTime(1992, 1, 1)
            };

            PersonManager personManager = new PersonManager(new PersonCheckManager());
            personManager.SignUp(person);
            return person;
        }
    }
}
