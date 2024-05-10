<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDataEntry.aspx.cs" Inherits="AdminSystem.Stock.ProductDataEntry" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Product Data Entry</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Product Data Entry</h2>
        <asp:Label ID="lblProductName" runat="server" Text="Product Name:" AssociatedControlID="txtProductName"></asp:Label>
        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblCategory" runat="server" Text="Category:" AssociatedControlID="txtCategory"></asp:Label>
        <asp:TextBox ID="txtCategory" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblPrice" runat="server" Text="Price:" AssociatedControlID="txtPrice"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" TextMode="Number"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblStockQuantity" runat="server" Text="Stock Quantity:" AssociatedControlID="txtStockQuantity"></asp:TextBox>
        <asp:TextBox ID="txtStockQuantity" runat="server" TextMode="Number"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblBrand" runat="server" Text="Brand:" AssociatedControlID="txtBrand"></asp:Label>
        <asp:TextBox ID="txtBrand" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Product" OnClick="BtnAdd_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update Product" OnClick="BtnUpdate_Click" />
    </form>
</body>
</html>
