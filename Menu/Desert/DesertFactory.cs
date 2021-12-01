using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Menu.Desert
{
    public static class DesertFactory
    {
        public static Desert MakeDesert(DesertType type)
        {
            switch (type)
            {
                case DesertType.LavaCake:
                    return new LavaCake();
                case DesertType.IceCream:
                    return new IceCream();
                
                default:
                    return null;
            }
        }
    }
}
