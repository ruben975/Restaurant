using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Restaurant.CashRegister
{
    public class CashRegister : ICashRegister
    {
        public static double Money { get; set; }
         
        public CashRegister()
        {

        }

        public void AmountMoney()
        {
            Console.WriteLine("Momentan suma banii in casa este " + Money + " RON");


        }

       

        public void Checkout(Cart cart)
        {
            PrintingBill(cart);
            cart.RemoveAll();
            
        }

        public void PrintDailyHistory(string day)
        {

            string text = System.IO.File.ReadAllText(@"C:\Users\nagyr\OneDrive\Desktop\Universitatea UEO\a-IngineriaSoftware\Project 1\Restaurant\"+day+".txt");
            Console.WriteLine(text);

        }

        public void PrintingBill(Cart cart)
        {
            string bill = "";

            string check = "";

            int counter;

            double totalMoney = 0;

            double totalVAT = 0;

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
                if (counter != -1)
                {
                    bill +="\n"+ counter + "   x   " + prod1.Price+ "   =   " + counter * prod1.Price + "\n";
                    totalMoney += prod1.Price * counter;
                    totalVAT += prod1.VAT * counter;
                }
            }
            bill += "\n    TOTAL:  " + totalMoney + "\n din care TVA : "+totalVAT;
            Money += totalMoney;
            Console.WriteLine(bill);

            //Amount of money in cashregister
            string path;
            path = @"C:\Users\nagyr\OneDrive\Desktop\Universitatea UEO\a-IngineriaSoftware\Project 1\Restaurant\CashRegisterMoney.txt";
        
        string s;
        int r = 0;
            using (StreamReader sr = File.OpenText(path))
            

                while ((s = sr.ReadLine()) != null)
                {
                    r = Int32.Parse(s);
                }

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(r + Money);
            }

            Money = Money + r;


            //For Printing Daily Bill
            DateTime date = DateTime.Now;
            string today = date.ToString("M");
            bool exists = false;
            path = @"C:\Users\nagyr\OneDrive\Desktop\Universitatea UEO\a-IngineriaSoftware\Project 1\Restaurant\" + today + ".txt";
            if (File.Exists(path)) exists = true;
            else
            
            {
                using (FileStream fs = File.Create(path))
                {


                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                if (exists == true)
                    sw.WriteLine("------------------------------");
                else
                    sw.WriteLine("------"+today + " history"+"------");
                sw.WriteLine(bill);
                
            }





        }
    }
}
