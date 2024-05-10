<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentConfirmDelete.aspx.cs" Inherits="AdminSystem.Payment.PaymentConfirmDelete" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Confirm Payment Deletion</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Confirm Payment Deletion</h2>
        <asp:Label ID="lblPaymentID" runat="server" Text="Payment ID:" AssociatedControlID="txtPaymentID"></asp:Label>
        <asp:TextBox ID="txtPaymentID" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
    </form>
</body>
</html>
