using Gun5.Odev5_1.GameOrder.Abstract;
using Gun5.Odev5_1.GameOrder.Entities;
using System;
using System.Collections.Generic;

namespace Gun5.Odev5_1.GameOrder.Concrete
{
    class OrderManager : IOrder
    {
        List<Order> _orders;

        public OrderManager()
        {
            _orders = new List<Order>();
        }

        public bool Add(List<Order> orders)
        {
            foreach (var order in orders)
            {
                if (_orders.Contains(order) == true)
                {
                    return false;
                }
            }

            _orders.AddRange(orders);
            return true;
        }

        public List<Order> ListOrders()
        {
            return _orders;
        }

        public bool Remove(Order order)
        {
            if (_orders.Remove(order) == true)
            {
                return true;
            }

            return false;
        }

        public void MakeSaleNow(Customer customer, List<Order> orders, List<Campaign> campaigns)
        {
            foreach (var order in orders)
            {
                if (customer.OwnOrders.Contains(order))
                {
                    Console.WriteLine(customer.FirstName + " already ordered " + order.ProductName);
                }
                else
                {
                    int money = customer.Money;
                    int productPrice = order.Price;
                    int discountRate = 0;
                    int afterMoney = 0;
                    foreach (var campaign in campaigns)
                    {
                        discountRate = campaign.DiscountRate;
                        afterMoney = money - (money * discountRate / 100);
                    }
                    afterMoney = afterMoney - productPrice;
                    Console.WriteLine("After your money is: " + afterMoney);
                    customer.OwnOrders.Add(order);
                }
            }
        }
    }
}