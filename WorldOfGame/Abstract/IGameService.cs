using System;
using System.Collections.Generic;
using System.Text;
using WorldOfGame.Entities;

namespace WorldOfGame.Abstract
{
    public interface IGameService
    {
        void SaleGame(Game game, Player player,Campaign campaign);
    }
}
