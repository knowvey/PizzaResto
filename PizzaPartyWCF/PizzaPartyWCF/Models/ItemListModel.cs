using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPartyWCF.Models
{
    class ItemListModel
    {
        pizzashopEntities db = new pizzashopEntities();

        public List<itemlist> GetItemList()
        {
            try
            {
                var getList = (from c in db.itemlists select c).ToList();
                return getList;               
            }
            catch (Exception)
            {
                return null;                
            }
        }

        public itemlist GetItem(String itemID)
        {
            try
            {
                var getItem = (from c in db.itemlists
                               where c.itemID == itemID
                               select c).First();

                return getItem;
            }
            catch (Exception)
            {
                return null;                
            }
        }
    }
}
