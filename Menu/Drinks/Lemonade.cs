using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant.Menu.Drinks
{
    public class Lemonade : Drink
    {
        public Lemonade()
              : base(DrinkType.Lemonade)
        {
            Type = DrinkType.Lemonade;
           
        }
        
      

        protected override void AddDescription()
        {
            Description = "500ml";
        }

        protected override void AddPrice()
        {
            Price = 10; VAT = (Price * VAT) / 100;
        }
    }
}

