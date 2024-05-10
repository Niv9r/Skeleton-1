<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentList.aspx.cs" Inherits="AdminSystem.Payment.PaymentList" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Payment List</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Payment List</h2>
        <asp:GridView ID="GridViewPayment" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="PaymentID" HeaderText="Payment ID" />
                <asp:BoundField DataField="OrderID" HeaderText="Order ID" />
                <asp:BoundField DataField="PaymentDate" HeaderText="Payment Date" />
                <asp:BoundField DataField="PaymentMethod" HeaderText="Payment Method" />
                <asp:BoundField DataField="Amount" HeaderText="Amount" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "PaymentDataEntry.aspx?PaymentID=" + Eval("PaymentID") %>' Text="Edit" />
                        <asp:HyperLink ID="lnkDelete" runat="server" NavigateUrl='<%# "PaymentConfirmDelete.aspx?PaymentID=" + Eval("PaymentID") %>' Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnAddNew" runat="server" Text="Add New Payment" PostBackUrl="PaymentDataEntry.aspx" />
    </form>
</body>
</html>
