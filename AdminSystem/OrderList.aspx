<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="AdminSystem.Order.OrderList" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Order List</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Order List</h2>
        <asp:GridView ID="GridViewOrder" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="OrderID" HeaderText="Order ID" />
                <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" />
                <asp:BoundField DataField="OrderDate" HeaderText="Order Date" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:BoundField DataField="TotalAmount" HeaderText="Total Amount" />
                <asp:BoundField DataField="OrderStatus" HeaderText="Order Status" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "OrderDataEntry.aspx?OrderID=" + Eval("OrderID") %>' Text="Edit" />
                        <asp:HyperLink ID="lnkDelete" runat="server" NavigateUrl='<%# "OrderConfirmDelete.aspx?OrderID=" + Eval("OrderID") %>' Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnAddNew" runat="server" Text="Add New Order" PostBackUrl="OrderDataEntry.aspx" />
    </form>
</body>
</html>
