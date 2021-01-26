using System;
using System.Collections.Generic;
using System.Text;
using WorldOfGame.Entities;

namespace WorldOfGame.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
