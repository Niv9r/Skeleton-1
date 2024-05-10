<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="AdminSystem.Stock.ProductList" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Product List</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Product List</h2>
        <asp:GridView ID="GridViewProduct" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                <asp:BoundField DataField="Category" HeaderText="Category" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:BoundField DataField="StockQuantity" HeaderText="Stock Quantity" />
                <asp:BoundField DataField="Brand" HeaderText="Brand" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "ProductDataEntry.aspx?ProductID=" + Eval("ProductID") %>' Text="Edit" />
                        <asp:HyperLink ID="lnkDelete" runat="server" NavigateUrl='<%# "ProductConfirmDelete.aspx?ProductID=" + Eval("ProductID") %>' Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnAddNew" runat="server" Text="Add New Product" PostBackUrl="ProductDataEntry.aspx" />
    </form>
</body>
</html>
