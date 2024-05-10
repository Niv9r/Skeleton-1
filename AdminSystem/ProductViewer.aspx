<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductViewer.aspx.cs" Inherits="AdminSystem.Stock.ProductViewer" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Product Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Product Viewer</h2>
        <asp:Label ID="lblProductID" runat="server" Text="Product ID:" AssociatedControlID="txtProductID"></asp:Label>
        <asp:TextBox ID="txtProductID" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblProductName" runat="server" Text="Product Name:" AssociatedControlID="txtProductName"></asp:TextBox>
        <asp:TextBox ID="txtProductName" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblCategory" runat="server" Text="Category:" AssociatedControlID="txtCategory"></asp:TextBox>
        <asp:TextBox ID="txtCategory" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblPrice" runat="server" Text="Price:" AssociatedControlID="txtPrice"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblStockQuantity" runat="server" Text="Stock Quantity:" AssociatedControlID="txtStockQuantity"></asp:TextBox>
        <asp:TextBox ID="txtStockQuantity" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblBrand" runat="server" Text="Brand:" AssociatedControlID="txtBrand"></asp:TextBox>
        <asp:TextBox ID="txtBrand" runat="server" ReadOnly="true"></asp:TextBox>
    </form>
</body>
</html>
