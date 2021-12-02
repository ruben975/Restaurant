using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Meat
{
    public abstract class Meat : Product
    { 

        public MeatType Type { get; set; }
        public SideDish.SideDishType SideDishType { get; set; }

        protected Meat(MeatType type)
        {
            SideDishType = SideDish.SideDishType.FrenchFries;
            this.VAT = 9;
            AddDescription();
            AddPrice();
        }

        public Meat changeSideDish(SideDish.SideDishType sideDishType)
        {
            SideDishType = sideDishType;

            return this; 
        }

        protected abstract void AddDescription();
        protected abstract void AddPrice();
       
        public override string ToString()
        {
            return $"{Type} ({Description} ) PRET: {Price} RON ";
        }
    }


}

