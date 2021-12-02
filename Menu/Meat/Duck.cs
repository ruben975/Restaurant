using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Meat
{
    public class Duck : Meat
    {
        public Duck()
            : base(MeatType.Duck)
        {
            Type = MeatType.Duck;
        }
        protected override void AddDescription()
        {
            if (SideDishType != null)
                Description = $"{SideDishType.GetType().Name}({SideDishType.Price} RON), carne de porc({CookType}), salata ";
            else
                Description = $" carne de rata({CookType}), salata ";
        }

        protected override void AddPrice()
        {
            Price += 40;
        }


    }
}