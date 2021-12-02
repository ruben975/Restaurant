using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Sauce
{
    public class Ketchup : Sauce
    { 
        public Ketchup()
              : base(SauceType.Ketchup)
        {
            Type = SauceType.Ketchup;
        }

        protected override void AddPrice()
        {
            Price = 3; VAT = (Price * VAT) / 100;
        }



    }


}

