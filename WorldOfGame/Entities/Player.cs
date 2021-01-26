using System;
using System.Collections.Generic;
using System.Text;
using WorldOfGame.Abstract;

namespace WorldOfGame.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
