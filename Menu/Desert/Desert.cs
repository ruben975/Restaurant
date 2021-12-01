using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Desert
{
    public abstract class Desert : Product
    {
        public int Price { get; set; }
        public string Description { get; set; }
        public double VAT { get; set; }
        public DesertType Type { get; set; }

        protected Desert(DesertType type)
        {
            this.VAT = 10;
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
