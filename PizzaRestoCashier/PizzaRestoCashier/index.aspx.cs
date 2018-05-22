using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Web.UI.HtmlControls;

namespace PizzaRestoCashier
{
    public partial class index : System.Web.UI.Page
    {
        PizzaRestoService.PizzaRestoClient server = new PizzaRestoService.PizzaRestoClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["orderList"] = new List<OrderList>();
                RefreshItemCounter();                
            }
            
            FillItemList();
        }

        private void FillItemList()
        {
            var itemList = server.GetItemList();

            for (int i = 0; i < itemList.Count(); i++)
            {             
                Button itemBtn = new Button();

                itemBtn.ID = itemList[i].itemID;
                itemBtn.Click += new EventHandler(ItemBtnClick);
                itemBtn.CssClass = "col-md-3 itemBtn";
                itemBtn.Text = itemList[i].itemID + "\n" + itemList[i].name;

                ItemListPnl.Controls.Add(itemBtn);                
            }            
        }

        private void ItemBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Boolean isOnList = false;
            List<OrderList> list = (List<OrderList>)Session["orderList"];
            var item = server.GetItem(btn.ID);
            double total = Convert.ToDouble(totalLbl.Text.Substring(2));

            foreach (OrderList oList in list)
            {
                if (oList.itemID == btn.ID)
                {
                    oList.qty++;
                    oList.price += item.price.Value;
                    isOnList = true;
                }                                
            }
            
            total += item.price.Value;

            if (!isOnList)
                list.Add(new OrderList { itemID = item.itemID, name = item.name,  qty = 1, price = item.price.Value });

            Session["orderList"] = list;

            totalLbl.Text = "₱ " + total.ToString();
            RefreshItemCounter();
        }

        private void RefreshItemCounter()
        {
            itemCounterGDV.DataSource = (List<OrderList>)Session["orderList"];
            itemCounterGDV.DataBind();            
        }

        protected void addCash_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(totalLbl.Text.Substring(2));
            double cash = Convert.ToDouble(cashTB.Text);
            double change = cash - total;

            cashLbl.Text = "₱ " + cash;
            changeLbl.Text = "₱ " + change;

            cashTB.Visible = false;
            addCash.Visible = false;
            cashLbl.Visible = true;

            AddOrder(total, cash);

            statusLbl.Text = "Order complete";
            newCustBtn.Visible = true;
        }

        protected void CounterBtns_Click(object sender, EventArgs e)
        {
            HtmlButton btn = (HtmlButton)sender;
             

            if (btn.ID == "arrowUpBtn")
            {
                if (itemCounterGDV.SelectedIndex >= 0)
                    itemCounterGDV.SelectedIndex -= 1;
            }
            else if (btn.ID == "arrowDownBtn")
            {
                if (itemCounterGDV.SelectedIndex < itemCounterGDV.Rows.Count)
                    itemCounterGDV.SelectedIndex += 1;
            }
            else
            {
                if (itemCounterGDV.SelectedIndex >= 0 && itemCounterGDV.SelectedIndex < itemCounterGDV.Rows.Count)
                {
                    String itemID = Server.HtmlDecode(itemCounterGDV.SelectedRow.Cells[0].Text);
                    List<OrderList> list = (List<OrderList>)Session["orderList"];
                    double total = Convert.ToDouble(totalLbl.Text.Substring(2));

                    foreach (OrderList item in list)
                    {
                        if (item.name == itemID)
                        {
                            list.Remove(item);
                            total -= item.price;
                            totalLbl.Text = "₱ " + total.ToString();
                            Session["orderList"] = list;
                            RefreshItemCounter();
                            itemCounterGDV.SelectedIndex = -1;
                            break;
                        }
                    }
                }
            }
        }

        protected void newCustBtn_Click(object sender, EventArgs e)
        {
            Session["orderList"] = new List<OrderList>();            
            this.Response.Redirect(this.Request.Url.ToString());            
        }

        private void AddOrder(double total, double cash)
        {
            List<OrderList> list = (List<OrderList>)Session["orderList"];
            int orderNo = server.AddCashierTransaction(cashNameTB.Text, custNameTB.Text, total, cash);
            server.AddKitchenOrder(orderNo);

            foreach (OrderList item in list)               
                server.AddOrder(item.itemID, item.qty, orderNo);            
        }
    }
}