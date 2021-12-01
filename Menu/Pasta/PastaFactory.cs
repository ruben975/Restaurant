using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Pasta
{
    public static class PastaFactory
    {
        public static Pasta MakePasta(PastaType type)
        {
            switch (type)
            {
                case PastaType.Carbonara:
                    return new Carbonara();
                case PastaType.SeaFood:
                    return new SeaFood();
                case PastaType.Gnochi:
                    return new Gnochi();
                case PastaType.QuattroFormaggi:
                    return new QuattroFormaggi();
                default:
                    return null;
            }
        }
    }
}
