using Gun5.Odev5_1.GameOrder.Abstract;
using Gun5.Odev5_1.GameOrder.Entities;
using MernisReferenceService;
using System;

namespace Gun5.Odev5_1.GameOrder.Adapters
{
    class MernisServiceAdapter : ICustomerCheckService
    {
        public bool Validation(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);

            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.BirthDate.Year);
        }
    }
}
