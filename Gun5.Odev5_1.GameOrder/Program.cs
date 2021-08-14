using Gun5.Odev5_1.GameOrder.Abstract;
using Gun5.Odev5_1.GameOrder.Adapters;
using Gun5.Odev5_1.GameOrder.Concrete;
using Gun5.Odev5_1.GameOrder.Entities;
using System;
using System.Collections.Generic;

namespace Gun5.Odev5_1.GameOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "SELAMİ",
                LastName = "DEMİR",
                NationalityId = "12120255722",
                BirthDate = new DateTime(1982, 1, 1),
                Money = 5000
            };

            Campaign campaign = new Campaign()
            {
                Id = 1,
                Name = "Yaz İndirimi",
                DiscountRate = 10
            };

            Campaign campaign2 = new Campaign()
            {
                Id = 2,
                Name = "Yaz İndirimi1",
                DiscountRate = 10
            };

            Order order = new Order()
            {
                Id = 1,
                CategoryId = 1,
                ProductName = "Call of Duty",
                Price = 100
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new List<Campaign> { campaign, campaign2 });

            ICustomerCheckService customerCheckService = new CustomerCheckManager();
            if (customerCheckService.Validation(customer) == true) 
            {
                OrderManager orderManager = new OrderManager();
                orderManager.Add(new List<Order> { order });
                orderManager.MakeSaleNow(customer, orderManager.ListOrders(), campaignManager.ListCampaigns());
            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulaması başarısız. Bu sebepten satış yapılamadı.");
            }
        }
    }
}
