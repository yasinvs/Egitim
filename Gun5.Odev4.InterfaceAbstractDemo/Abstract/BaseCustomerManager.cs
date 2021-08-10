using Gun5.Odev4.InterfaceAbstractDemo.Entities;
using System;

namespace Gun5.Odev4.InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
