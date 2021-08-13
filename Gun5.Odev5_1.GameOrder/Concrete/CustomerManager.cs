using Gun5.Odev5_1.GameOrder.Abstract;
using Gun5.Odev5_1.GameOrder.Entities;
using System;

namespace Gun5.Odev5_1.GameOrder.Concrete
{
    class CustomerManager : ICustomer
    {
        ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void SignUp(Customer customer)
        {
            if (_customerCheckService.Validation(customer) == true)
            {
                Console.WriteLine("Kayıt işlemi tamamlandı !");
            }
            else
            {
                Console.WriteLine("Kayıt işlemi başarısız");
            }
        }
    }
}
