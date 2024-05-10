﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDataEntry.aspx.cs" Inherits="AdminSystem.Customer.CustomerDataEntry" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Customer Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Customer Data Entry</h2>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name:" AssociatedControlID="txtFirstName"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name:" AssociatedControlID="txtLastName"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblEmail" runat="server" Text="Email:" AssociatedControlID="txtEmail"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblPhone" runat="server" Text="Phone:" AssociatedControlID="txtPhone"></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblCountryCode" runat="server" Text="Country Code:" AssociatedControlID="ddlCountryCode"></asp:Label>
        <asp:DropDownList ID="ddlCountryCode" runat="server">
            <asp:ListItem Text="US" Value="US"></asp:ListItem>
            <asp:ListItem Text="UK" Value="UK"></asp:ListItem>
            <asp:ListItem Text="AU" Value="AU"></asp:ListItem>
            <asp:ListItem Text="CA" Value="CA"></asp:ListItem>
            <asp:ListItem Text="IN" Value="IN"></asp:ListItem>
        </asp:DropDownList>
        <br /><br />
        <asp:Label ID="lblAddress" runat="server" Text="Address:" AssociatedControlID="txtAddress"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblIsActive" runat="server" Text="Is Active:" AssociatedControlID="chkIsActive"></asp:Label>
        <asp:CheckBox ID="chkIsActive" runat="server"></asp:CheckBox>
        <br /><br />
        <asp:Label ID="lblPassword" runat="server" Text="Password:" AssociatedControlID="txtPassword"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Customer" OnClick="BtnAdd_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update Customer" OnClick="BtnUpdate_Click" />
    </form>
</body>
</html>
