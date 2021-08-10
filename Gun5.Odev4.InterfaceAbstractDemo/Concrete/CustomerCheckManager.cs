using Gun5.Odev4.InterfaceAbstractDemo.Abstract;
using Gun5.Odev4.InterfaceAbstractDemo.Entities;

namespace Gun5.Odev4.InterfaceAbstractDemo.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}