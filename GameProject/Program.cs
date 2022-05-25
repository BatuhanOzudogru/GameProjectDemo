using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Batuhan";
            gamer1.LastName = "Özüdoğru";
            gamer1.Id = 1;
            gamer1.NationalityId = 11111111111;
            gamer1.DateOfBirth = new DateTime(1997, 01, 23);


            Gamer gamer2 = new Gamer();
            gamer2.FirstName = "Kaan";
            gamer2.LastName = "Özüdoğru";
            gamer2.Id = 2;
            gamer2.NationalityId = 22222222222;
            gamer2.DateOfBirth = new DateTime(2007, 01, 8);

            Game game1 = new Game();
            game1.GameName = "GTA";
            game1.GamePrice = 549.90;
            Game game2 = new Game();
            game2.GameName = "Rdr2";
            game2.GamePrice = 399.0;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Winter Sale";
            campaign1.DiscountPercent = 0.35;
            campaign1.CampaingId = 1;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignName = "Summer Sale";
            campaign2.DiscountPercent = 0.25;
            campaign2.CampaingId = 2;

            Campaign campaign3 = new Campaign();
            campaign3.CampaignName = "Student Sale";
            campaign3.DiscountPercent = 0.50;
            campaign3.CampaingId = 3;


            SaleManager saleManager = new SaleManager();
            saleManager.DiscountSale(game2, gamer1, campaign3);
            saleManager.NormalSale(game1, gamer2, campaign2);
            Console.WriteLine("-----------------------------------------------");

            GamerCheckManager gamerCheckManager = new GamerCheckManager();
            gamerCheckManager.CheckIfRealPerson(gamer2);
            Console.WriteLine("-----------------------------------------------");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Delete(campaign3);
            Console.WriteLine("-----------------------------------------------");




        }

    
    }
}
