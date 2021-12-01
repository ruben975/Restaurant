using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Pasta
{
    public class Gnochi : Pasta
    {
        public Gnochi()
              : base(PastaType.Gnochi)
        {
        }
        protected override void AddDescription()
        {
            Description = "cartofi,ou,parmezan";
        }

        protected override void AddPrice()
        {
            Price = 30; VAT = (Price * VAT) / 100;
        }
    }
}
