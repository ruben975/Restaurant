using System.Collections.Generic;

using Restaurant.Menu.Desert;
using Restaurant.Menu.Pasta;
using Restaurant.Menu.Drinks;
using Restaurant.Menu.Pizza;
using Restaurant.Menu.Sauce;
using Restaurant.Menu.SideDish;



namespace Restaurant
{
   public class ListMenu
    {
        List<Product> menu = new List<Product>();
        public List<Product>  GetMenu()
        {
           
            Desert desert = DesertFactory.MakeDesert(DesertType.LavaCake);
            Pizza pizza = PizzaFactory.MakePizza(PizzaType.Capricoasa);

            menu.Add(desert); 
            menu.Add(pizza);
            
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
