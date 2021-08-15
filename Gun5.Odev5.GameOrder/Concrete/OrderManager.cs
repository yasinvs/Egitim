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

        public List<Order> GetListOrders()
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
            int discountRate = 0;
            int money = customer.Money;
            int afterMoney = 0;
            int afterDiscount = 0;

            foreach (var campaign in campaigns)
            {
                discountRate += campaign.DiscountRate;
            }

            foreach (var order in orders)
            {
                if (customer.OwnOrders.Exists(e => e.Id == order.Id))
                {
                    Console.WriteLine(customer.FirstName + " already ordered " + order.ProductName);
                }
                else
                {
                    int productPrice = order.Price;
                    if (afterDiscount == 0)
                    {
                        afterDiscount = productPrice - (productPrice * discountRate / 100);
                        afterMoney = money - afterDiscount;
                    }
                    else
                    {
                        afterMoney = afterMoney - productPrice;
                    }
                    Console.WriteLine("After your money is: " + afterMoney);
                    customer.OwnOrders.Add(order);
                }
            }
        }
    }
}