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
        public abstract void Checkout();
        public abstract void PrintingBill();
        public abstract void PrintDailyHistory();
        public abstract void AmountMoney();

    }
}
