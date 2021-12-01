﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Drinks
{
    public class Water : Drink
    {
        public Water()
              : base(DrinkType.Water)
        {
        }
        protected override void AddDescription()
        {
            Description = "500ml";
        }

        protected override void AddPrice()
        {
            Price = 3; VAT = (Price * VAT) / 100;
        }
    }
}

