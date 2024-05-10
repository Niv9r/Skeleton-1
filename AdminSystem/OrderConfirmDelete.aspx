<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderConfirmDelete.aspx.cs" Inherits="AdminSystem.Order.OrderConfirmDelete" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Confirm Order Deletion</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Confirm Order Deletion</h2>
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID:" AssociatedControlID="txtOrderID"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
    </form>
</body>
</html>
