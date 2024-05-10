<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="AdminSystem.Customer.CustomerList" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Customer List</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Customer List</h2>
        <asp:GridView ID="GridViewCustomer" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="IsActive" HeaderText="Is Active" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "CustomerDataEntry.aspx?CustomerID=" + Eval("CustomerID") %>' Text="Edit" />
                        <asp:HyperLink ID="lnkDelete" runat="server" NavigateUrl='<%# "CustomerConfirmDelete.aspx?CustomerID=" + Eval("CustomerID") %>' Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnAddNew" runat="server" Text="Add New Customer" PostBackUrl="CustomerDataEntry.aspx" />
    </form>
</body>
</html>
