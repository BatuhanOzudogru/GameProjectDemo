using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerCheckManager : IGamerCheckService
    {
        public void CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.FirstName=="Batuhan" || gamer.FirstName == "Kaan")
            {
                Console.WriteLine(gamer.FirstName+" İsimli oyuncu eklendi");
            }
            else
            {
                Console.WriteLine("Lütfen doğru bilgi giriniz");
            }
        }

        
    }
    
}
