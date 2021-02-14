using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.CheckGamer
{
    public abstract class BaseCheckGamerService : ICheckIfRealGamer
    {
        public virtual bool CheckIfRealGamer(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
