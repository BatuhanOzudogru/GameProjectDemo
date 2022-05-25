using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISaleService
    {
        void DiscountSale(Game game, Gamer gamer, Campaign campaign);

        void NormalSale(Game game, Gamer gamer, Campaign campaign);
    }
}
