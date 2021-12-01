using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Sauce
{
    public abstract class Sauce : Product
    {
        public int Price { get; set; }
        public string Description { get; set; }
        public double VAT { get; set; }
        public SauceType Type { get; set; }

        protected Sauce(SauceType type)
        {
            this.VAT = 9;
            
            AddPrice();
        }
        protected abstract void AddPrice();

        public override string ToString()
        {
            return $"{Type}  PRET: {Price} RON ";
        }
    }


}


