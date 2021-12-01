using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Pizza
{
    public static class PizzaFactory
    {
        public static Pizza MakePizza(PizzaType type)
        {
            switch (type)
            {
               case PizzaType.Capricoasa:
                    return new Capricoasa();
               case PizzaType.QuattroStagioni:
                    return new QuattroStagioni();
               case PizzaType.Margherita:
                    return new Margherita();
               case PizzaType.ProsciutoEFunghi:
                    return new ProsciutoEFunghi(); 
                default:
                    return null;
            }
        }
    }
}
