using Gun5.Odev5_1.GameOrder.Entities;
using System.Collections.Generic;

namespace Gun5.Odev5_1.GameOrder.Abstract
{
    public interface ICampaign
    {
        List<Campaign> campaigns();
        void Add(Campaign campaign);
        void Remove(Campaign campaign);
        void Update(Campaign campaign, Campaign newCampaign);
    }
}
