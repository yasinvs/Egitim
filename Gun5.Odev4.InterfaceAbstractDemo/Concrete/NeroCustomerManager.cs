using Gun5.Odev4.InterfaceAbstractDemo.Abstract;
using Gun5.Odev4.InterfaceAbstractDemo.Entities;
using System;

namespace Gun5.Odev4.InterfaceAbstractDemo.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (!_customerCheckService.CheckIfRealPerson(customer))
            {
                throw new Exception("Not a valid person");
            }
            base.Save(customer);
        }
    }
}
