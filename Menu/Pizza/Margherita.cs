using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Pizza
{
    public class Margherita : Pizza
    {


        public Margherita()
            : base(PizzaType.Margherita)
        {
            Type = PizzaType.Margherita;
        }
        protected override void AddDescription()
        {
            Description = "Sos rosii, mozzarella";
        }

        protected override void AddPrice()
        {
            Price = 19; VAT = (Price * VAT) / 100;
        }

    }
}
