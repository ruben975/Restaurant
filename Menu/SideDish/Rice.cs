using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.SideDish
{
   public class Rice : SideDish
    {
        public Rice()
              :base(SideDishType.Rice) 
                   {
            Type = SideDishType.Rice;
        }

        protected override void AddDescription()
        {
            Description = "cu sare";
        }

        protected override void AddPrice()
        {
            Price = 15; VAT = (Price * VAT) / 100;
        }
    }
}
