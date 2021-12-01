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
        }
        protected override void AddDescription()
        {
            Description = "500ml";
        }

        protected override void AddPrice()
        {
            Price = 5; VAT = (Price * VAT) / 100;
        }
    }
}

