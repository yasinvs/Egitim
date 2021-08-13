using Gun5.Odev5.OyunDemo.Abstract;
using Gun5.Odev5.OyunDemo.Entities;
using System;
using System.Collections.Generic;

namespace Gun5.Odev5.OyunDemo.Classes
{
    class OfferManager : IOffer
    {
        List<Offer> _offerList;

        public OfferManager()
        {
           _offerList = new List<Offer>();
        }

        public void Add(Offer offer)
        {
            _offerList.Add(offer);
            Console.WriteLine(offer.Name + " Added!");
        }
        public void Delete(Offer offer)
        {
            _offerList.Remove(offer);
            Console.WriteLine(offer.Name + " Removed!");
        }

        public List<Offer> GetOffers()
        {
            return _offerList;
        }

        public Offer Update(Offer offer, Offer tempOffer)
        {
            _offerList.Remove(offer);
            _offerList.Add(tempOffer);
            offer = tempOffer;
            return offer;
        }
    }
}
