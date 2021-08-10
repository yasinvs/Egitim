using Gun5.Odev5.OyunDemo.Entities;

namespace Gun5.Odev5.OyunDemo.Abstract
{
    interface IOrder
    {
        void Order(Person person, Order order, Offer offer);
    }
}
