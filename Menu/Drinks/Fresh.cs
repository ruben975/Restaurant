using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Restaurant.Menu.Drinks
{
    public class Fresh : Drink
    {
        public Fresh()
              : base(DrinkType.Fresh)
        {
            Type = DrinkType.Fresh;

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
