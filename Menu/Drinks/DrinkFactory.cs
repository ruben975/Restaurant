using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Drinks
{
    public static class DrinkFactory
    {
        public static Drink MakeDrink(DrinkType type)
        {
            switch (type)
            {
                case DrinkType.Water:
                    return new Water();
                case DrinkType.Cola:
                    return new Cola();
               case DrinkType.Lemonade:
                    return new Lemonade();
                case DrinkType.Fresh:
                    return new Fresh(); 
                default:
                    return null;
            }
        }
    }
}
