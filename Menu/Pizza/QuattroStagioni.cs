using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Pizza
{
    public class QuattroStagioni : Pizza
    {


        public QuattroStagioni()
            : base(PizzaType.QuattroStagioni)
        {
            Type = PizzaType.QuattroStagioni;
        }
        protected override void AddDescription()
        {
            Description = "Sos rosii, mozzarella, salam, sunca, ciuperci, masline";
        }

        protected override void AddPrice()
        {
            Price = 22; VAT = (Price * VAT) / 100;
        }

       

    }
}
