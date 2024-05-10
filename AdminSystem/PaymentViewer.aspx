<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentViewer.aspx.cs" Inherits="AdminSystem.Payment.PaymentViewer" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Payment Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Payment Viewer</h2>
        <asp:Label ID="lblPaymentID" runat="server" Text="Payment ID:" AssociatedControlID="txtPaymentID"></asp:Label>
        <asp:TextBox ID="txtPaymentID" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID:" AssociatedControlID="txtOrderID"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblPaymentDate" runat="server" Text="Payment Date:" AssociatedControlID="txtPaymentDate"></asp:Label>
        <asp:TextBox ID="txtPaymentDate" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblPaymentMethod" runat="server" Text="Payment Method:" AssociatedControlID="txtPaymentMethod"></asp:Label>
        <asp:TextBox ID="txtPaymentMethod" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblAmount" runat="server" Text="Amount:" AssociatedControlID="txtAmount"></asp:Label>
        <asp:TextBox ID="txtAmount" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblStatus" runat="server" Text="Status:" AssociatedControlID="txtStatus"></asp:Label>
        <asp:TextBox ID="txtStatus" runat="server" ReadOnly="true"></asp:TextBox>
    </form>
</body>
</html>
