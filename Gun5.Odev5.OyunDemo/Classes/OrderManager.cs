using Gun5.Odev5.OyunDemo.Abstracts;
using Gun5.Odev5.OyunDemo.Entities;
using System;

namespace Gun5.Odev5.OyunDemo.Classes
{
    class OrderManager : IOrder
    {
        public void Order(Order order, Offer offer)
        {
            Console.WriteLine("{0} isimli satış yapıldı", order.ProductName);
        }
    }
}
