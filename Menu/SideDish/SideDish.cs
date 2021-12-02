using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.SideDish
{
    public abstract class SideDish : Product
    { 
        public SideDishType Type { get; set; }

        protected SideDish(SideDishType type)
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