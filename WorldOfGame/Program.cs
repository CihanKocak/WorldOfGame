using System;
using WorldOfGame.Abstract;
using WorldOfGame.Concrete;
using WorldOfGame.Entities;

namespace WorldOfGame
{
    class Program
    {
        static void Main(string[] args)
        { 

            Player player1 = new Player();
            player1.Id = 1;
            player1.FirstName = "Cihan";
            player1.LastName = "Koçak";
            player1.NationalityId = "12345678910";
            player1.DateOfBirth = new DateTime(1984, 10, 25);

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Have a nice Friday";
            campaign1.CampaignDiscount = 50.00;

            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "Kafa Topu 2";
            game1.GamePrice = 100;

            IPlayerService playerService = new PlayerManager(new PlayerCheckManager());
            playerService.Save(player1);
            playerService.Update(player1);
            playerService.Delete(player1);

            Console.WriteLine("------------------------------------------");

            ICampaignService campaignService = new CampaignManager();
            campaignService.Add(campaign1);
            campaignService.Update(campaign1);
            campaignService.Delete(campaign1);

            Console.WriteLine("------------------------------------------");

            IGameService gameService = new GameManager();
            gameService.SaleGame(game1, player1, campaign1);

            Console.ReadLine();
        }
    }
}
