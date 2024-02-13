using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Bank
{
    public class BankAccount
    {
        public int TotalMoney { get; private set; }
        float Cashback { get; set; }

        public BankAccount(int totalMoney, float cashback)
        {
            TotalMoney = totalMoney;
            Cashback = cashback;
        }

        public bool AddMoney(int money)
        {
            if (money < 0) { return false; }
            else { TotalMoney += money; return true; }
        }
        public bool BuySomething(int price, float cashback)
        {
            if (price < 0) { return false; }
            else
            {
                TotalMoney -= price;
                TotalMoney += (int)(price * (cashback / 100)); 
                return true;
                
            }
           
        }
    }
}
