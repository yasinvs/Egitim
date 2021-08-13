using System;
using System.Collections.Generic;

namespace Gun5.Odev5.OyunDemo.Entities
{
    class Customer
    {
        public Customer()
        {
            OwnOrder = new List<Order>();
        }
        public string IdentificationNo  { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Order> OwnOrder { get; set; }
    }
}
