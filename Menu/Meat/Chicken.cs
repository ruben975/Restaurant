using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Meat
{
    public class Chicken : Meat
    {
        public Chicken()
            : base(MeatType.Chicken)
        {
            Type = MeatType.Chicken;
        }
        protected override void AddDescription()
        {
            if (SideDishType != null)
                Description = $"{SideDishType.GetType().Name}({SideDishType.Price} RON), carne de porc({CookType}), salata ";
            else
                Description = $" carne de pui({CookType}), salata ";
        }

        protected override void AddPrice()
        {
            Price += 10;
        }


    }
}
