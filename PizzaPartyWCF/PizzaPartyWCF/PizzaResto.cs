using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PizzaPartyWCF.Models;

namespace PizzaPartyWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class PizzaResto : IPizzaResto
    {
        CashierModel cModel = new CashierModel();
        ItemListModel iModel = new ItemListModel();
        OrderListModel oModel = new OrderListModel();
        KitchenModel kModel = new KitchenModel();

        public int AddCashierTransaction(String cashName, String custName, double total, double cash)
        {
            return cModel.AddCashierTransaction(cashName, custName, total, cash);
        }

        public List<itemlist> GetItemList()
        {
            return iModel.GetItemList();
        }

        public void AddOrder(String itemID, int qty, int orderNo)
        {
            oModel.AddOrder(itemID, qty, orderNo);
        }

        public List<orderlist> GetOrderList(int orderNo)
        {
            return oModel.GetOrderList(orderNo);
        }

        public void AddKitchenOrder(int orderNo)
        {
            kModel.AddKitchenOrder(orderNo);
        }

        public void SetOrderComplete(int orderNo)
        {
            kModel.SetOrderComplete(orderNo);
        }

        public itemlist GetItem(String itemID)
        {
            return iModel.GetItem(itemID);
        }

        public List<kitchen> GetKitchenOrders()
        {
            return kModel.GetKitchenOrders();
        }

        public List<kitchen> GetIncompleteOrder()
        {
            return kModel.GetIncompleteOrder();
        }

        public List<kitchen> GetCompleteOrder()
        {
            return kModel.GetCompleteOrder();
        }
    }
}
