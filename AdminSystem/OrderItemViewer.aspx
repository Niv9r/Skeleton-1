<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderItemViewer.aspx.cs" Inherits="AdminSystem.Order.OrderItemViewer" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Order Item Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Order Item Viewer</h2>
        <asp:Label ID="lblOrderItemID" runat="server" Text="Order Item ID:" AssociatedControlID="txtOrderItemID"></asp:Label>
        <asp:TextBox ID="txtOrderItemID" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID:" AssociatedControlID="txtOrderID"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblProductID" runat="server" Text="Product ID:" AssociatedControlID="txtProductID"></asp:Label>
        <asp:TextBox ID="txtProductID" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity:" AssociatedControlID="txtQuantity"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblUnitPrice" runat="server" Text="Unit Price:" AssociatedControlID="txtUnitPrice"></asp:Label>
        <asp:TextBox ID="txtUnitPrice" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price:" AssociatedControlID="txtTotalPrice"></asp:Label>
        <asp:TextBox ID="txtTotalPrice" runat="server" ReadOnly="true"></asp:TextBox>
    </form>
</body>
</html>
