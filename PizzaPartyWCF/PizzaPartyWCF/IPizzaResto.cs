using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PizzaPartyWCF.Models; 

namespace PizzaPartyWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPizzaResto
    {
        [OperationContract]
        int AddCashierTransaction(String cashName, String custName, double total, double cash);

        [OperationContract]
        List<itemlist> GetItemList();

        [OperationContract]
        void AddOrder(String itemID, int qty, int orderNo);

        [OperationContract]
        List<orderlist> GetOrderList(int orderNo);

        [OperationContract]
        void AddKitchenOrder(int orderNo);

        [OperationContract]
        void SetOrderComplete(int orderNo);

        [OperationContract]
        itemlist GetItem(String itemID);

        [OperationContract]
        List<kitchen> GetKitchenOrders();

        [OperationContract]
        List<kitchen> GetIncompleteOrder();

        [OperationContract]
        List<kitchen> GetCompleteOrder();
    }    
}
