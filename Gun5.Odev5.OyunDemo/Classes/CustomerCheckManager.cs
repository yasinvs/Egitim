using Gun5.Odev5.OyunDemo.Abstract;
using Gun5.Odev5.OyunDemo.Entities;

namespace Gun5.Odev5.OyunDemo.Classes
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool Check(Customer person)
        {
            return true;
        }
    }
}
