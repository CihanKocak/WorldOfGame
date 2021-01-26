using System;
using System.Collections.Generic;
using System.Text;
using WorldOfGame.Abstract;
using WorldOfGame.Entities;

namespace WorldOfGame.Concrete
{
    class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckPlayerRealPerson(Player player)
        {
            if (player.NationalityId == "12345678910")
            {
                return true;
            }
            else
            {
                throw new Exception("Invalid User! please check your information! ");
            }
        }
    }
}
