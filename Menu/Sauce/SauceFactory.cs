using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Sauce
{
    public static class SauceFactory
    {
        public static Sauce MakeSauce(SauceType type)
        {
            switch (type)
            {
                case SauceType.Ketchup:
                    return new Ketchup();
                case SauceType.Mayo:
                    return new Mayo();
                case SauceType.Tzatziki:
                    return new Tzatziki();
                default:
                    return null;
            }
        }
    }
}
