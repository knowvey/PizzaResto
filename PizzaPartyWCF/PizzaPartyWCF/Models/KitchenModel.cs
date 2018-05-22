using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPartyWCF.Models
{
    class KitchenModel
    {
        pizzashopEntities db = new pizzashopEntities();

        public void AddKitchenOrder(int orderNo)
        {
            kitchen newOrder = new kitchen
            {
                orderNo = orderNo,
                isCompleted = "no"
            };

            db.kitchens.Add(newOrder);
            db.SaveChanges();
        }

        public void SetOrderComplete(int orderNo)
        {
            try
            {
                var order = (from c in db.kitchens
                             where c.orderNo == orderNo
                             select c).First();

                order.isCompleted = "yes";
                db.SaveChanges();
            }
            catch (Exception)
            {                
            }
        }

        public List<kitchen> GetKitchenOrders()
        {
            try
            {
                var list = (from c in db.kitchens select c).ToList();
                return list;
            }
            catch (Exception)
            {
                return null;                
            }
        }

        public List<kitchen> GetIncompleteOrder()
        {
            try
            {
                var list = (from c in db.kitchens
                            where c.isCompleted == "no"
                            select c).ToList();
                return list;
            }
            catch (Exception)
            {
                return null;                
            }
        }

        public List<kitchen> GetCompleteOrder()
        {
            try
            {
                var list = (from c in db.kitchens
                            where c.isCompleted == "yes"
                            select c).ToList();
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
