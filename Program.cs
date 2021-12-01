using System;
using Restaurant.Menu.Pizza;
using Restaurant.Menu.Pasta;
using Restaurant.Menu.Desert;
using Restaurant.Menu.Sauce;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            ListMenu menu = ListMenu.GetInstance();
            menu.GetMenu().ForEach(i => Console.Write("{0}\n", i));


        }
    }
}
