using System;
using System.Collections.Generic;
using System.Text;
using WorldOfGame.Entities;

namespace WorldOfGame.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckPlayerRealPerson(Player player);
    }
}
