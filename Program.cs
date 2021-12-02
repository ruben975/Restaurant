using System;
using Restaurant.Menu.Pizza;
using Restaurant.Menu.Pasta;
using Restaurant.Menu.Desert;
using Restaurant.Menu.Sauce;
using Restaurant.Menu.Meat;
using System.Collections.Generic;
using Restaurant;
namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListMenu menu = ListMenu.GetInstance();
            //menu.GetMenu().ForEach(i => Console.Write("{0}\n\n", i));

            Product pizza = PastaFactory.MakePasta(PastaType.Carbonara);
            Product pizz = PizzaFactory.MakePizza(PizzaType.Margherita);
            Product meat = MeatFactory.MakeMeat(MeatType.Hamburger);
            Product meat1 = MeatFactory.MakeMeat(MeatType.Hamburger);
            Product pasta = PastaFactory.MakePasta(PastaType.Gnochi);
            Console.WriteLine(pizza.Price);
            Console.WriteLine(pasta.Price);

            // (meat1 as Meat).changeSideDish(Menu.SideDish.SideDishType.FrenchFries);

            Cart cart = new Cart();
            cart.addProduct(pizza);
            cart.addProduct(pizza);
            cart.addProduct(meat1);
        
            

          //  Console.WriteLine(cart);
 
        }
    }
}
