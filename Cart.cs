using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant;
using Restaurant.Menu.Meat;
using System.IO;
using Restaurant.Menu.Drinks;

namespace Restaurant
{
    public class Cart : List<Product>
    {
        public List<Product> cart = new List<Product>();

        public Cart()
        { }
        public Cart addProduct(Product product)
        {
            if (product.GetType().Name.Contains("Lemonade") || product.GetType().Name.Contains("Fresh"))
            {
                string path = "";
                if (product.GetType().Name.Contains("Lemonade"))
                {  path = @"C:\Users\nagyr\OneDrive\Desktop\Universitatea UEO\a-IngineriaSoftware\Project 1\Restaurant\StockLimonada.txt"; }
                else
                {  path = @"C:\Users\nagyr\OneDrive\Desktop\Universitatea UEO\a-IngineriaSoftware\Project 1\Restaurant\StockFresh.txt"; }
                string s;
                int r = 0;
                using (StreamReader sr = File.OpenText(path))
                {

                    while ((s = sr.ReadLine()) != null)
                    {
                        r = Int32.Parse(s);
                    }

                }
                if (r > 1)
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(r - 2);
                    }
                    cart.Add(product);
                }
                else Console.WriteLine("Limonada nu putem sa facem :(");
               
            }
            else cart.Add(product);


            return this;
        }
       
        public Cart removeProduct(Product product)
        {
            cart.Remove(product);
            return this;
        }
       
        public override string ToString()
        {
            string result = $"In cosul tau este/sunt:\n";
            foreach (Product i in cart)
            {
                if (i.GetType().FullName.Contains("Meat")) result += i.GetType().Name + "\n";
                result += i.GetType().Name+"\n" ;
            }
            return result;
        }

    }
}
