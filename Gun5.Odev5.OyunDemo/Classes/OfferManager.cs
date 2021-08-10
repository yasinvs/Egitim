using Gun5.Odev5.OyunDemo.Abstract;
using Gun5.Odev5.OyunDemo.Entities;
using System;

namespace Gun5.Odev5.OyunDemo.Classes
{
    class OfferManager : IOffer
    {
        public void Add(Offer offer)
        {
            Console.WriteLine("Kampanya eklendi");
        }
        public void Delete(Offer offer)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Offer offer)
        {
            Console.WriteLine("Kampanya güncelleştirildi");
        }
    }
}
