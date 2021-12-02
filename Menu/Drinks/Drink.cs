using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Drinks
{
    public abstract class Drink : Product
    {
       
        public DrinkType Type { get; set; }

        protected Drink(DrinkType type)
        {
            this.VAT = 9;
            AddDescription();
            AddPrice();
        }


        protected abstract void AddDescription();
        protected abstract void AddPrice();
        public override string ToString()
        {
            return $"{Type} ({Description} ) PRET: {Price} RON ";
        }
    }


}