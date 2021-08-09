using Gun5.Odev5.OyunDemo.Adapters;
using Gun5.Odev5.OyunDemo.Classes;
using Gun5.Odev5.OyunDemo.Entities;
using System;

namespace Gun5.Odev5.OyunDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager(new MernisServiceAdapter());
            personManager.SignUp(new Person() { IdentificationNo = "111111111111", FirstName = "", LastName = "", BirthDate = new DateTime(1994, 2, 19) });
        }
    }
}
