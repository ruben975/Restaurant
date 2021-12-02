using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Restaurant.Menu.Pasta
{
    public class QuattroFormaggi : Pasta
    {
        public QuattroFormaggi()
              : base(PastaType.QuattroFormaggi)
        {
            Type = PastaType.QuattroFormaggi;
        }
        protected override void AddDescription()
        {
            Description = "crema, cimbru, piper, Takeggio, Gruyere ras, fusilli uscate, penne";
        }

        protected override void AddPrice()
        {
            Price = 35; VAT = (Price * VAT) / 100;
        }



    }
}