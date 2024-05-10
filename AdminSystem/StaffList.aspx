<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffList.aspx.cs" Inherits="AdminSystem.Staff.StaffList" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Staff List</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Staff List</h2>
        <asp:GridView ID="GridViewStaff" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="StaffID" HeaderText="Staff ID" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" />
                <asp:BoundField DataField="Role" HeaderText="Role" />
                <asp:BoundField DataField="IsActive" HeaderText="Is Active" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HyperLink ID="lnkEdit" runat="server" NavigateUrl='<%# "StaffDataEntry.aspx?StaffID=" + Eval("StaffID") %>' Text="Edit" />
                        <asp:HyperLink ID="lnkDelete" runat="server" NavigateUrl='<%# "StaffConfirmDelete.aspx?StaffID=" + Eval("StaffID") %>' Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnAddNew" runat="server" Text="Add New Staff" PostBackUrl="StaffDataEntry.aspx" />
    </form>
</body>
</html>
