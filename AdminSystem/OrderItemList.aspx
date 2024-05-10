<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderItemList.aspx.cs" Inherits="AdminSystem.Order.OrderItemList" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Order Item List</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Order Item List</h2>
        <asp:GridView ID="GridViewOrderItem" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="OrderItemID" HeaderText="Order Item ID" />
                <asp:BoundField DataField="OrderID" HeaderText="Order ID" />
                <asp:BoundField DataField="ProductID" HeaderText="Product ID" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" />
                <asp:BoundField DataField="TotalPrice" HeaderText="Total Price" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "OrderItemDataEntry.aspx?OrderItemID=" + Eval("OrderItemID") %>' Text="Edit" />
                        <asp:HyperLink ID="lnkDelete" runat="server" NavigateUrl='<%# "OrderItemConfirmDelete.aspx?OrderItemID=" + Eval("OrderItemID") %>' Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnAddNew" runat="server" Text="Add New Order Item" PostBackUrl="OrderItemDataEntry.aspx" />
    </form>
</body>
</html>
