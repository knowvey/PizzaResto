<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PizzaPartyKitchen.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pizza Party Resto | Kitchen</title>
    <link href="bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="bootstrap/css/bootstrap-theme.css" rel="stylesheet" />
    <link href="bootstrap/css/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="script1" runat="server"></asp:ScriptManager>
    <asp:Timer ID="refTimer" runat="server" Interval="1000" OnTick="refTimer_Tick"></asp:Timer>                  
        <div class="container">
            <div class="header">
                <h1>Pizza Party Kitchen</h1>            
            </div>
            <div class="orderListContainer">                
                <asp:UpdatePanel ID="OrdersUPanel" UpdateMode="Conditional" runat="server">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="refTimer" EventName="Tick" />
                    </Triggers>
                </asp:UpdatePanel>
                <asp:GridView ID="GridView1" runat="server"  GridLines="None"></asp:GridView>               
            </div>
        </div>                 
    </form>
</body>
</html>
