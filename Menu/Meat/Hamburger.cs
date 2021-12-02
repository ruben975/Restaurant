using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Meat
{
    public class Hamburger : Meat
    {   public Hamburger()
            : base(MeatType.Hamburger)
        {
            Type = MeatType.Hamburger;
        }
        protected override void AddDescription()
        {
            Description = "asdas";
        }

        protected override void AddPrice()
        {
            Price = 40;
        }

     
    }
}
