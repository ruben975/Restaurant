using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Sauce
{
    public class Tzatziki : Sauce
    {
        public Tzatziki()
              : base(SauceType.Tzatziki)
        {
        }

        protected override void AddPrice()
        {
            Price = 3; VAT = (Price * VAT) / 100;
        }



    }


}
