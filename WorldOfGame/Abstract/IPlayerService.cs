using System;
using System.Collections.Generic;
using System.Text;
using WorldOfGame.Entities;

namespace WorldOfGame.Abstract
{
    public interface IPlayerService
    {
        void Save(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
