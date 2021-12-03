using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Menu.Desert;


namespace Restaurant.CashRegister
{
   public interface ICashRegister
    {
        public abstract void Checkout(Cart cart);
        public abstract void PrintingBill(Cart cart);
        public abstract void PrintDailyHistory(string day);
        public abstract void AmountMoney();

    }
}
