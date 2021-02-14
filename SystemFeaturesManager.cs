using GameProject.CheckGamer;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SystemFeaturesManager : ISystemFeatures
    {
        BaseCheckGamerService _baseCheckGamer;

        public SystemFeaturesManager(BaseCheckGamerService baseCheckGamer)
        {
            _baseCheckGamer = baseCheckGamer;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("{0} {1} deleted", gamer.FirstName, gamer.LastName);
        }

        public void Register(Gamer gamer)
        {
            if (_baseCheckGamer.CheckIfRealGamer(gamer)==true)
            {
                Console.WriteLine("{0} {1} Succesfully registered", gamer.FirstName, gamer.LastName);
            }
            else
            {
                Console.WriteLine("{0} {1} failed to register", gamer.FirstName, gamer.LastName);
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("{0} {1} updated", gamer.FirstName, gamer.LastName);
        }
    }
}
