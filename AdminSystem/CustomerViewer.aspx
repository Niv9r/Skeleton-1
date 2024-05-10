<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerViewer.aspx.cs" Inherits="AdminSystem.Customer.CustomerViewer" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Customer Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Customer Viewer</h2>
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID:" AssociatedControlID="txtCustomerID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblFirstName" runat="server" Text="First Name:" AssociatedControlID="txtFirstName"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name:" AssociatedControlID="txtLastName"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblEmail" runat="server" Text="Email:" AssociatedControlID="txtEmail"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblPhone" runat="server" Text="Phone:" AssociatedControlID="txtPhone"></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblCountryCode" runat="server" Text="Country Code:" AssociatedControlID="txtCountryCode"></asp:Label>
        <asp:TextBox ID="txtCountryCode" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblAddress" runat="server" Text="Address:" AssociatedControlID="txtAddress"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblIsActive" runat="server" Text="Is Active:" AssociatedControlID="chkIsActive"></asp:Label>
        <asp:CheckBox ID="chkIsActive" runat="server" Enabled="false"></asp:CheckBox>
    </form>
</body>
</html>
