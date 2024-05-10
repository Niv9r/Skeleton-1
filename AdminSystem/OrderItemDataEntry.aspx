<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderItemDataEntry.aspx.cs" Inherits="AdminSystem.Order.OrderItemDataEntry" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Order Item Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Order Item Data Entry</h2>
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID:" AssociatedControlID="txtOrderID"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblProductID" runat="server" Text="Product ID:" AssociatedControlID="txtProductID"></asp:Label>
        <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity:" AssociatedControlID="txtQuantity"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server" TextMode="Number"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblUnitPrice" runat="server" Text="Unit Price:" AssociatedControlID="txtUnitPrice"></asp:Label>
        <asp:TextBox ID="txtUnitPrice" runat="server" TextMode="Number"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price:" AssociatedControlID="txtTotalPrice"></asp:Label>
        <asp:TextBox ID="txtTotalPrice" runat="server" TextMode="Number"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Order Item" OnClick="BtnAdd_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update Order Item" OnClick="BtnUpdate_Click" />
    </form>
</body>
</html>
