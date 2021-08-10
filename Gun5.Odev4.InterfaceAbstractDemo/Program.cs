using Gun5.Odev4.InterfaceAbstractDemo.Abstract;
using Gun5.Odev4.InterfaceAbstractDemo.Adapters;
using Gun5.Odev4.InterfaceAbstractDemo.Concrete;
using Gun5.Odev4.InterfaceAbstractDemo.Entities;
using System;

namespace Gun5.Odev4.InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer() { DateOfBirth = new DateTime(1986, 1, 6), FirstName = "ENGİN", LastName = "DEMİROĞ", NationalityId = "28861108", Id = 1 });
        }
    }
}
