using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.SideDish
{
    public class MashedPotatoes : SideDish
    {
        public MashedPotatoes()
              : base(SideDishType.MashedPotatoes)
        { Type = SideDishType.MashedPotatoes; }

        protected override void AddDescription()
        {
            Description = "sare si piper";
        }

        protected override void AddPrice()
        {
            Price = 15; VAT = (Price * VAT) / 100;
        }
    }
}
