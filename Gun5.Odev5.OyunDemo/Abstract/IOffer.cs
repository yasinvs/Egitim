using Gun5.Odev5.OyunDemo.Entities;

namespace Gun5.Odev5.OyunDemo.Abstract
{
    interface IOffer
    {
        void Add(Offer offer);
        void Delete(Offer offer);
        void Update(Offer offer);
    }
}
