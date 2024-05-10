<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentDataEntry.aspx.cs" Inherits="AdminSystem.Payment.PaymentDataEntry" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Payment Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Payment Data Entry</h2>
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID:" AssociatedControlID="txtOrderID"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblPaymentDate" runat="server" Text="Payment Date:" AssociatedControlID="txtPaymentDate"></asp:Label>
        <asp:TextBox ID="txtPaymentDate" runat="server" TextMode="Date"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblPaymentMethod" runat="server" Text="Payment Method:" AssociatedControlID="txtPaymentMethod"></asp:Label>
        <asp:TextBox ID="txtPaymentMethod" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblAmount" runat="server" Text="Amount:" AssociatedControlID="txtAmount"></asp:Label>
        <asp:TextBox ID="txtAmount" runat="server" TextMode="Number"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblStatus" runat="server" Text="Status:" AssociatedControlID="txtStatus"></asp:Label>
        <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Payment" OnClick="BtnAdd_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update Payment" OnClick="BtnUpdate_Click" />
    </form>
</body>
</html>
