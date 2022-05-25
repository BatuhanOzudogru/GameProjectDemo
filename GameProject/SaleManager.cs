using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager : ISaleService
    {
        public void DiscountSale(Game game, Gamer gamer, Campaign campaign)
        {
            double newPrice = game.GamePrice - (game.GamePrice * campaign.DiscountPercent);
            Console.WriteLine(game.GameName + " Adlı oyun " + gamer.FirstName + " Adlı oyuncuya " + campaign.CampaignName + " kampayanyası uygulanmıştır." + " Yeni Fiyat: " + newPrice );
            
        }

        public void NormalSale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " Adlı oyun " + gamer.FirstName + " Adlı oyuncuya satılmıştır" +  "  Fiyat: " + game.GamePrice);
        }
    }
}
