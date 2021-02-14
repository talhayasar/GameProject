using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.CheckGamer
{
    class RealCheckGamerService : BaseCheckGamerService
    {
        public override bool CheckIfRealGamer(Gamer gamer)
        {
            if (gamer.GameId == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
