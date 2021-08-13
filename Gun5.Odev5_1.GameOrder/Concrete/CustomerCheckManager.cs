using Gun5.Odev5_1.GameOrder.Abstract;
using Gun5.Odev5_1.GameOrder.Entities;

namespace Gun5.Odev5_1.GameOrder.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool Validation(Customer customer)
        {
            return true;
        }
    }
}
