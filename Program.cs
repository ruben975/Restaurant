﻿using System;
using Restaurant.Menu.Pizza;
using Restaurant.Menu.Pasta;
using Restaurant.Menu.Desert;
using Restaurant.Menu.Sauce;
using Restaurant.Menu.Meat;
using Restaurant.Menu.Drinks;
using Restaurant.Menu.SideDish;
using System.Collections.Generic;
using Restaurant;
using System.IO;
namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            // ListMenu menu = ListMenu.GetInstance();
            // menu.GetMenu().ForEach(i => Console.Write("{0}\n\n", i));

            /*  Product pizza = PastaFactory.MakePasta(PastaType.Carbonara);
             Product pizz = PizzaFactory.MakePizza(PizzaType.Margherita);
             Product meat = MeatFactory.MakeMeat(MeatType.Hamburger);
             Product meat1 = MeatFactory.MakeMeat(MeatType.Hamburger);
             Product pasta = PastaFactory.MakePasta(PastaType.Gnochi);
             Console.WriteLine(pizza.Price);


             // (meat as Meat).RemoveSideDish();
             // (meat as Meat).changeSideDish(SideDishFactory.MakeSideDish(SideDishType.MashedPotatoes));


             (meat as Meat).ChangeCookType(CookType.wellCooked);
             Console.WriteLine(meat);
             Cart cart = new Cart();
             cart.addProduct(pizza);
             cart.addProduct(pizza);
             cart.addProduct(meat);



              */
            Product pasta = PastaFactory.MakePasta(PastaType.Gnochi);
            Product prod = DrinkFactory.MakeDrink(DrinkType.Lemonade);
            Cart cart = new Cart();
            cart.addProduct(prod);
            cart.addProduct(pasta);
            Console.WriteLine(cart);
        }
    }
}
