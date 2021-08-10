using Gun5.Odev4.InterfaceAbstractDemo.Entities;

namespace Gun5.Odev4.InterfaceAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
