using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Restaurant.Menu.Drinks
{
    public class Fresh : Drink
    {
        public Fresh()
              : base(DrinkType.Fresh)
        {
            string path = @"C:\Users\nagyr\OneDrive\Desktop\Universitatea UEO\a-IngineriaSoftware\Project 1\Restaurant\Stock.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("1");
            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }
        protected override void AddDescription()
        {
            Description = "500ml";
        }

        protected override void AddPrice()
        {
            Price = 5; VAT = (Price * VAT) / 100;
        }
    }
}
