<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerConfirmDelete.aspx.cs" Inherits="AdminSystem.Customer.CustomerConfirmDelete" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Confirm Customer Deletion</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Confirm Customer Deletion</h2>
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID:" AssociatedControlID="txtCustomerID"></asp:TextBox>
        <asp:TextBox ID="txtCustomerID" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
    </form>
</body>
</html>
