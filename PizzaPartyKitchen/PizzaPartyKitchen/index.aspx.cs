using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace PizzaPartyKitchen
{
    public partial class index : System.Web.UI.Page
    {
        PizzaRestoService.PizzaRestoClient service = new PizzaRestoService.PizzaRestoClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            FillOrdersPnl();
        }

        private void FillOrdersPnl()
        {
            var kitchenList = service.GetIncompleteOrder();          

            for (int i = 0; i < kitchenList.Count(); i++ )
            {
                if (i < 8)
                {
                    var orderList = service.GetOrderList(kitchenList[i].orderNo.Value);

                    Panel orderPnl = new Panel();
                    Panel orderListPnl = new Panel();
                    Panel btnPnl = new Panel();
                    Button completeBtn = new Button();
                    GridView orderListGDV = new GridView();
                    List<OrderList> list = new List<OrderList>();

                    foreach (var order in orderList)
                    {
                        var item = service.GetItem(order.itemID);
                        list.Add(new OrderList { Name = item.name, Qty = order.qty.Value });
                    }

                    orderListGDV.GridLines = GridLines.None;
                    orderListGDV.DataSource = list;
                    orderListGDV.DataBind();
                    orderListGDV.CssClass = "orderCont";

                    completeBtn.Text = "X";
                    completeBtn.ID = kitchenList[i].orderNo.Value.ToString();
                    completeBtn.Click += new EventHandler(this.completeBtn_Click);

                    orderPnl.CssClass = "col-md-3 orderPnl";
                    orderListPnl.CssClass = "orderListPnl";
                    completeBtn.CssClass = "btn btn-primary btnPnl";
                    btnPnl.CssClass = "text-center";

                    orderListPnl.Controls.Add(orderListGDV);
                    btnPnl.Controls.Add(completeBtn);

                    orderPnl.Controls.Add(orderListPnl);
                    orderPnl.Controls.Add(btnPnl);

                    OrdersUPanel.ContentTemplateContainer.Controls.Add(orderPnl);
                }
            }
        }

        protected void refTimer_Tick(object sender, EventArgs e)
        {
            OrdersUPanel.Update();
        }

        protected void completeBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            service.SetOrderComplete(Convert.ToInt32(btn.ID));
            OrdersUPanel.Update();
        }
    }
    
}