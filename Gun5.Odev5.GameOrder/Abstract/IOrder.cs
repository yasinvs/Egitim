using Gun5.Odev5_1.GameOrder.Entities;
using System.Collections.Generic;

namespace Gun5.Odev5_1.GameOrder.Abstract
{
    interface IOrder
    {
        List<Order> GetListOrders();
        bool Add(List<Order> orders);
        bool Remove(Order order);
        void MakeSaleNow(Customer customer, List<Order> orders, List<Campaign> campaigns);
    }
}
