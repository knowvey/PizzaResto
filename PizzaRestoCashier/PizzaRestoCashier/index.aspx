<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PizzaRestoCashier.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pizza Party Resto | Cashier</title>
    <link href="bootstrap/css/bootstrap.css" rel="stylesheet" />    
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="bootstrap/css/bootstrap-theme.css" rel="stylesheet" />
    <link href="bootstrap/css/font-awesome.min.css" rel="stylesheet" />    
    <link href="bootstrap/css/style.css" rel="stylesheet" />
    <script src="bootstrap/js/jquery.min.js"></script>
    <script src="bootstrap/js/bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="script1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="panel1" runat="server"><ContentTemplate>
    <div class="container">
        <div class="col-md-8 nopadding">
            <div class="header">
                <h1>Pizza Party Resto</h1>
                <div class="itemListContainer">                       
                    <asp:Panel ID="ItemListPnl" CssClass="itemListContent" runat="server"></asp:Panel>
                </div>                
            </div>
        </div>
        <div class="col-md-4 nopadding">
            <div class="cashierInfo">                
                <h5>Cashier: <asp:TextBox ID="cashNameTB" Width="100%" runat="server"></asp:TextBox></h5>
                <h5>Customer: <asp:TextBox ID="custNameTB" Width="100%" runat="server"></asp:TextBox></h5>
            </div>
            <div class="itemCounter">
                <div class="col-md-10 nopadding">
                    <div class="itemGDVContent">
                        <asp:GridView ID="itemCounterGDV" CssClass="itemCounterGDV" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="None" PageSize="99" ShowHeaderWhenEmpty="True">
                            <Columns>
                                <asp:BoundField HeaderText="Item" DataField="name">
                                    <HeaderStyle CssClass="paddingGDV" />
                                    <ItemStyle CssClass="paddingGDV" />
                                </asp:BoundField>
                                <asp:BoundField HeaderText="Qty" DataField="qty" />
                                <asp:BoundField HeaderText="Price" DataField="price" />
                            </Columns>                            
                            <HeaderStyle BackColor="#CCCCCC" Font-Bold="False" ForeColor="Black" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />                            
                            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F7F7F7" />
                            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                            <SortedDescendingCellStyle BackColor="#E5E5E5" />
                            <SortedDescendingHeaderStyle BackColor="#242121" />                                                       
                        </asp:GridView>
                    </div>                    
                </div>
                <div class="col-md-2 nopadding colBtns">
                    <button id="arrowUpBtn" class="counterBtn" runat="server" onserverclick="CounterBtns_Click"><i class="fa fa-arrow-up"></i></button>
                    <button id="arrowDownBtn" class="counterBtn" runat="server" onserverclick="CounterBtns_Click"><i class="fa fa-arrow-down"></i></button>
                    <button id="removeBtn" class="counterBtn" runat="server" onserverclick="CounterBtns_Click"><i class="fa fa-remove"></i></button>
                </div>
            </div>
            <div class="totalBar">      
                <h4>Total: <asp:Label ID="totalLbl" CssClass="totalLbl" runat="server" Text="₱ 0"></asp:Label></h4>                                                
                <h5 class="cashChange">Cash: 
                    <asp:Button ID="addCash" OnClick="addCash_Click" CssClass="totalLbl" runat="server" Text="Enter" />
                    <asp:TextBox ID="cashTB" Width="100" CssClass="totalLbl" runat="server"></asp:TextBox>
                    <asp:Label ID="cashLbl" CssClass="totalLbl" Visible="false" runat="server" Text="₱ 0"></asp:Label>
                </h5>
                <h5 class="cashChange">Change: <asp:Label ID="changeLbl" CssClass="totalLbl" runat="server" Text="₱ 0"></asp:Label></h5>           
            </div>     
            <div class="statusBar">
                <h4>Status: 
                    <asp:Label ID="statusLbl" runat="server" Text="New Customer"></asp:Label>
                    <asp:Button ID="newCustBtn" OnClick="newCustBtn_Click" Visible="false" CssClass="newCust" runat="server" Text="New Customer" />
                </h4>
            </div>       
        </div>  
    </div>
    </ContentTemplate></asp:UpdatePanel> 
    </form>
</body>
</html>
