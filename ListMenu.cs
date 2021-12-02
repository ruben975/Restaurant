using System.Collections.Generic;

using Restaurant.Menu.Desert;
using Restaurant.Menu.Pasta;
using Restaurant.Menu.Drinks;
using Restaurant.Menu.Pizza;
using Restaurant.Menu.Sauce;
using Restaurant.Menu.SideDish;
using Restaurant.Menu.Meat;



namespace Restaurant
{
   public class ListMenu
    {
        List<Product> menu = new List<Product>();



        public List<Product>  GetMenu()
        {   //PIZZA
            menu.Add(PizzaFactory.MakePizza(PizzaType.Capricoasa));
            menu.Add(PizzaFactory.MakePizza(PizzaType.Margherita));
            menu.Add(PizzaFactory.MakePizza(PizzaType.QuattroStagioni));
            menu.Add(PizzaFactory.MakePizza(PizzaType.ProsciutoEFunghi));



            //MEAT 
            menu.Add(MeatFactory.MakeMeat(MeatType.Hamburger).RemoveSideDish());
            menu.Add(MeatFactory.MakeMeat(MeatType.Chicken).RemoveSideDish());
            menu.Add(MeatFactory.MakeMeat(MeatType.Duck).RemoveSideDish());
            menu.Add(MeatFactory.MakeMeat(MeatType.Steak).RemoveSideDish());

            //PASTA
            menu.Add(PastaFactory.MakePasta(PastaType.Carbonara));
            menu.Add(PastaFactory.MakePasta(PastaType.Gnochi));
            menu.Add(PastaFactory.MakePasta(PastaType.QuattroFormaggi));
            menu.Add(PastaFactory.MakePasta(PastaType.SeaFood));

            //SAUCE
            menu.Add(SauceFactory.MakeSauce(SauceType.Ketchup));
            menu.Add(SauceFactory.MakeSauce(SauceType.Mayo));
            menu.Add(SauceFactory.MakeSauce(SauceType.Tzatziki));

            //Side Dish 
            menu.Add(SideDishFactory.MakeSideDish(SideDishType.FrenchFries));
            menu.Add(SideDishFactory.MakeSideDish(SideDishType.MashedPotatoes));
            menu.Add(SideDishFactory.MakeSideDish(SideDishType.Rice));

            //DESERT
            menu.Add(DesertFactory.MakeDesert(DesertType.IceCream));
            menu.Add(DesertFactory.MakeDesert(DesertType.LavaCake));


            return menu;
        }

        public void GetClass()
        {
         
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static ListMenu GetInstance()
        {
            if (instance == null)
            { instance = new ListMenu(); }
            return instance;

        }

        private static ListMenu instance = null;

        private ListMenu() { }

    }
}
