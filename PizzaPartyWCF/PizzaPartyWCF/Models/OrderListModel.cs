using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPartyWCF.Models
{
    class OrderListModel
    {
        String itemID { get; set; }
        int qty { get; set; }

        pizzashopEntities db = new pizzashopEntities();

        public void AddOrder(String itemID, int qty, int orderNo)
        {
            orderlist item = new orderlist
            {
                itemID = itemID,
                qty = qty,
                orderNo = orderNo
            };

            db.orderlists.Add(item);
            db.SaveChanges();
        }

        public List<orderlist> GetOrderList(int orderNo)
        {
            try
            {
                var getList = (from c in db.orderlists
                               where c.orderNo == orderNo
                               select c).ToList();
                return getList;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
