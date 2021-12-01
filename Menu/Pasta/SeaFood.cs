using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant.Menu.Pasta
{
    public class SeaFood : Pasta
    {
        public SeaFood()
              : base(PastaType.SeaFood)
        {
        }
        protected override void AddDescription()
        {
            Description = "unt, usturoi, suc de lamaie, vin alb, crema, patrunjel, sare, piper";
        }

        protected override void AddPrice()
        {
            Price = 31; VAT = (Price * VAT) / 100;
        }



    }
}
