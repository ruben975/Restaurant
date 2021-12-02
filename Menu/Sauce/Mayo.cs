using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Sauce
{
    public class Mayo : Sauce
    {
        public Mayo()
              : base(SauceType.Mayo)
        {
            Type = SauceType.Mayo;
        }

        protected override void AddPrice()
        {
            Price = 3; VAT = (Price * VAT) / 100;
        }



    }


}
