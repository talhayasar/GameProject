using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface ISystemFeatures
    {
        void Register(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
