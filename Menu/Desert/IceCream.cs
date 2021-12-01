using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Desert
{
    public class IceCream : Desert
    {
        public IceCream()
            : base(DesertType.IceCream)
        {
        }
        protected override void AddDescription()
        {
            Description = "frisca naturala, lapte integral, ou, zahar";
           
        }
        
        protected override void AddPrice()
        {
            Price = 10; VAT = (Price * VAT) / 100;
        }
    }
}
