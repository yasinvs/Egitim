using Gun5.Odev5_1.GameOrder.Abstract;
using System;
using System.Collections.Generic;

namespace Gun5.Odev5_1.GameOrder.Entities
{
    public class Customer : IEntity
    {
        public Customer()
        {
            OwnOrders = new List<Order>();
        }
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Order> OwnOrders { get; set; }
    }
}