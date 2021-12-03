using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.CashRegister
{
    public class CashRegister : ICashRegister
    {
        public int Money { get; set; }
         
        public CashRegister()
        {

        }

        public void AmountMoney()
        {
            
        }

       

        public void Checkout(Cart cart)
        {
            PrintingBill(cart);
            cart.RemoveAll();
        }

        public void PrintDailyHistory()
        {
            throw new NotImplementedException();
        }

        public void PrintingBill(Cart cart)
        {
            string bill = "";

            string check = "";

            int counter =0;

            foreach (Product prod1 in cart.GetCart())
            {


                if (check.Contains(prod1.GetType().Name)) continue;
                else
                    bill += prod1.GetType().Name;

                counter = 0;
                foreach (Product prod2 in cart.GetCart())
                {
                    if (prod1 == prod2) { counter++;  }
                    if (check.Contains(prod1.GetType().Name)) counter = -1;
                }
                check += prod1.GetType().Name;
                if(counter != -1)
                bill += " " + counter+"\n";

            }

            Console.WriteLine(bill);



        }
    }
}
