using Gun5.Odev5.OyunDemo.Abstract;
using Gun5.Odev5.OyunDemo.Entities;
using System;

namespace Gun5.Odev5.OyunDemo.Classes
{
    class OrderManager : IOrder
    {
        public void Order(Customer person, Order order, Offer offer)
        {
            Console.WriteLine("{0} isimli satış yapıldı", order.ProductName);
            Console.WriteLine("{0} isimli kampanya tanımlandı", offer.Name);
        }
    }
}
