using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Meat
{
    public static class MeatFactory
    {
        public static Meat MakeMeat(MeatType type)
        {
            switch (type)
            {
               case MeatType.Chicken:
                    return new Chicken();
                case MeatType.Duck:
                    return new Duck(); 
                case MeatType.Hamburger:
                    return new Hamburger();
                case MeatType.Steak:
                    return new Steak(); 
                default:
                    return null;
            }
        }
    }
}
