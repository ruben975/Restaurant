using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Pizza
{
    public class ProsciutoEFunghi : Pizza
    {


        public ProsciutoEFunghi()
            : base(PizzaType.ProsciutoEFunghi)
        {
        }
        protected override void AddDescription()
        {
            Description = "Sos rosii, mozzarella, sunca";
        }

        protected override void AddPrice()
        {
            Price = 20; VAT = (Price * VAT) / 100;
        }



    }
}
