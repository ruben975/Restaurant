﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant;

namespace Restaurant.Menu.Pizza
{
   public abstract class Pizza : Product
    {
        public int Price { get; set; }
        public string Description { get; set; }
        
        public string Name { get; set; }

        public double VAT { get; set; }
        public PizzaType Type { get; set; }
       
    protected Pizza(PizzaType type)
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
