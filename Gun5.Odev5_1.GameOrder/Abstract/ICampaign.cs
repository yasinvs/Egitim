using Gun5.Odev5_1.GameOrder.Entities;
using System.Collections.Generic;

namespace Gun5.Odev5_1.GameOrder.Abstract
{
    public interface ICampaign
    {
        List<Campaign> GetListCampaigns();
        bool Add(List<Campaign> campaigns);
        bool Remove(Campaign campaign);
        bool Update(Campaign campaign, Campaign newCampaign);
    }
}
