using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPartyWCF.Models
{
    class CashierModel
    {
        pizzashopEntities db = new pizzashopEntities();

        public int AddCashierTransaction(String cashName, String custName, double total, double cash)
        {
            cashier newCashier = new cashier
            {
                cashierName = cashName,
                custName = custName,
                total = total,
                cash = cash
            };

            db.cashiers.Add(newCashier);
            db.SaveChanges();

            return newCashier.orderNo;
        }        
    }
}
