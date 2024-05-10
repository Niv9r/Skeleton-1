<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderViewer.aspx.cs" Inherits="AdminSystem.Order.OrderViewer" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Order Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Order Viewer</h2>
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID:" AssociatedControlID="txtOrderID"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID:" AssociatedControlID="txtCustomerID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblOrderDate" runat="server" Text="Order Date:" AssociatedControlID="txtOrderDate"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblStatus" runat="server" Text="Status:" AssociatedControlID="txtStatus"></asp:Label>
        <asp:TextBox ID="txtStatus" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblTotalAmount" runat="server" Text="Total Amount:" AssociatedControlID="txtTotalAmount"></asp:Label>
        <asp:TextBox ID="txtTotalAmount" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblOrderStatus" runat="server" Text="Order Status:" AssociatedControlID="chkOrderStatus"></asp:Label>
        <asp:CheckBox ID="chkOrderStatus" runat="server" Enabled="false"></asp:CheckBox>
    </form>
</body>
</html>
