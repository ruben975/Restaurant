using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Drinks
{
    public class Cola : Drink
    { 
        public Cola()
              : base(DrinkType.Cola)
        {
            Type = DrinkType.Cola;
           
        }
        protected override void AddDescription()
        {
            Description = "300ml";
        }

        protected override void AddPrice()
        {
            VAT = 12;
            Price = 6; VAT = (Price * VAT) / 100;
        }
    }
}

