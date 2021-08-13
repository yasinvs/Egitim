using Gun5.Odev5.OyunDemo.Abstract;
using Gun5.Odev5.OyunDemo.Entities;
using System;

namespace Gun5.Odev5.OyunDemo.Classes
{
    class CustomerManager : ICustomerService
    {
        private ICustomerCheckService _personCheckService;

        public CustomerManager(ICustomerCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        public void SignUp(Customer person)
        {
            if (_personCheckService.Check(person))
            {
                Console.WriteLine("Aşağıda belirtilen kullanıcı sisteme kayıt edildi;\n" +
                    "TcNo : " + person.IdentificationNo + "\n" +
                    "Adı Soyadı : " + person.FirstName + " " + person.LastName + "\n" +
                    "Doğum Tarihi : " + person.BirthDate);
            }
            else
            {
                throw new Exception("User not validation");
            }
        }
    }
}
