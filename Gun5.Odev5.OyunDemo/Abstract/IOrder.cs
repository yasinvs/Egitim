using Gun5.Odev5.OyunDemo.Entities;

namespace Gun5.Odev5.OyunDemo.Abstract
{
    interface IOrder
    {
        void Order(Customer person, Order order, Offer offer);
    }
}
