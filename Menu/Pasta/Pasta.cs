using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Pasta
{
    public abstract class Pasta : Product
    {
        public int Price { get; set; }
        public string Description { get; set; }
        public double VAT { get; set; }
        public PastaType Type { get; set; }

        protected Pasta(PastaType type)
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

