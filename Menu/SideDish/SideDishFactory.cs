using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.SideDish
{
    public static class SideDishFactory
    {
        public static SideDish MakeSideDish(SideDishType type)
        {
            switch (type)
            {
                case SideDishType.FrenchFries:
                    return new FrenchFries();
                case SideDishType.Rice:
                    return new Rice();
                case SideDishType.MashedPotatoes:
                    return new MashedPotatoes();
                default:
                    return null;
            }
        }
    }
}
