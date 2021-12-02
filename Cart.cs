using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant;
using Restaurant.Menu.Meat;

namespace Restaurant
{
    public class Cart : List<Product>
    {
        public List<Product> cart = new List<Product>();

        public Cart()
        { }
        public Cart addProduct(Product product)
        {
            cart.Add(product);
            return this;
        }
       
        public Cart removeProduct(Product product)
        {
            cart.Remove(product);
            return this;
        }
       
        public override string ToString()
        {
            string result = $"You have in your cart:\n";
            foreach (Product i in cart)
            {
                if (i.GetType().FullName.Contains("Meat")) result += i.GetType().Name + "\n";
                result += i.GetType().Name+"\n" ;
            }
            return result;
        }

    }
}
