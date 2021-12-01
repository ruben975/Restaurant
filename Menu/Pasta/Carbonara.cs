using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Pasta
{
    public class Carbonara : Pasta
    {
        public Carbonara()
              : base(PastaType.Carbonara)
        {
        }
        protected override void AddDescription()
        {
            Description = "paste, bacon, smantana lichida, oua, parmezan, sare, piper, ulei masline";
        }

        protected override void AddPrice()
        {
            Price = 26; VAT = (Price * VAT) / 100;
        }



    }
}
