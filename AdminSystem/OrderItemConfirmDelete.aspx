<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderItemConfirmDelete.aspx.cs" Inherits="AdminSystem.Order.OrderItemConfirmDelete" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Confirm Order Item Deletion</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Confirm Order Item Deletion</h2>
        <asp:Label ID="lblOrderItemID" runat="server" Text="Order Item ID:" AssociatedControlID="txtOrderItemID"></asp:Label>
        <asp:TextBox ID="txtOrderItemID" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
    </form>
</body>
</html>
