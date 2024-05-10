<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderDataEntry.aspx.cs" Inherits="AdminSystem.Order.OrderDataEntry" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Order Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Order Data Entry</h2>
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID:" AssociatedControlID="txtCustomerID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblOrderDate" runat="server" Text="Order Date:" AssociatedControlID="txtOrderDate"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" TextMode="Date"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblStatus" runat="server" Text="Status:" AssociatedControlID="txtStatus"></asp:Label>
        <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblTotalAmount" runat="server" Text="Total Amount:" AssociatedControlID="txtTotalAmount"></asp:Label>
        <asp:TextBox ID="txtTotalAmount" runat="server" TextMode="Number"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblOrderStatus" runat="server" Text="Order Status:" AssociatedControlID="chkOrderStatus"></asp:Label>
        <asp:CheckBox ID="chkOrderStatus" runat="server"></asp:CheckBox>
        <br /><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Order" OnClick="BtnAdd_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update Order" OnClick="BtnUpdate_Click" />
    </form>
</body>
</html>
