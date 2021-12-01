using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Pizza
{
    public class Capricoasa : Pizza
    {


        public Capricoasa()
            : base(PizzaType.Capricoasa)
        {
        }
        protected override void AddDescription()
        {
            Description = "sos, mozzarella, sunca, bacon, salam, ciuperci, ceapa, ardei, masline";
        }

        protected override void AddPrice()
        {
            Price = 25; VAT = (Price * VAT) / 100;
        }
        
    }
}
