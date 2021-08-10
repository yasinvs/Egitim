using Gun5.Odev5.OyunDemo.Entities;
using System;
using MernisServiceReference;
using Gun5.Odev5.OyunDemo.Abstract;

namespace Gun5.Odev5.OyunDemo.Adapters
{
    class MernisServiceAdapter : IPersonCheckService
    {
        public bool Check(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrula(Convert.ToInt64(person.IdentificationNo), person.FirstName.ToUpper(), person.LastName.ToUpper(), person.BirthDate.Year);
        }
    }
}
