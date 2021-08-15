using Gun5.Odev5_1.GameOrder.Abstract;
using Gun5.Odev5_1.GameOrder.Entities;
using System.Collections.Generic;

namespace Gun5.Odev5_1.GameOrder.Concrete
{
    class CampaignManager : ICampaign
    {
        List<Campaign> _campaigns;

        public CampaignManager()
        {
            _campaigns = new List<Campaign>();
        }
        public bool Add(List<Campaign> campaigns)
        {
            foreach (var campaign in campaigns)
            {
                if (_campaigns.Contains(campaign) == true)
                {
                    return false;
                }
            }

            _campaigns.AddRange(campaigns);
            return true;
        }

        public List<Campaign> GetListCampaigns()
        {
            return _campaigns;
        }

        public bool Remove(Campaign campaign)
        {
            if (_campaigns.Remove(campaign) == true)
            {
                return true;
            }

            return false;
        }

        public bool Update(Campaign campaign, Campaign newCampaign)
        {
            for (int i = 0; i < _campaigns.Count; i++)
            {
                if (_campaigns.Contains(campaign) == true)
                {
                    _campaigns[i].Id = newCampaign.Id;
                    _campaigns[i].Name = newCampaign.Name;
                    _campaigns[i].DiscountRate = newCampaign.DiscountRate;
                    return true;
                }
            }
            return false;

        }
    }
}
