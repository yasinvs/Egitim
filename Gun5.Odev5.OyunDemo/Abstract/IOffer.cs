using Gun5.Odev5.OyunDemo.Entities;
using System.Collections.Generic;

namespace Gun5.Odev5.OyunDemo.Abstract
{
    interface IOffer
    {
        List<Offer> GetOffers();
        void Add(Offer offer);
        void Delete(Offer offer);
        Offer Update(Offer offer, Offer tempOffer);
    }
}
