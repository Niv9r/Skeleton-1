<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffViewer.aspx.cs" Inherits="AdminSystem.Staff.StaffViewer" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Staff Viewer</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Staff Viewer</h2>
        <asp:Label ID="lblStaffID" runat="server" Text="Staff ID:" AssociatedControlID="txtStaffID"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" ReadOnly="true"></asp:TextBox>
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
        <asp:Label ID="lblRole" runat="server" Text="Role:" AssociatedControlID="txtRole"></asp:Label>
        <asp:TextBox ID="txtRole" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Label ID="lblIsActive" runat="server" Text="Is Active:" AssociatedControlID="chkIsActive"></asp:Label>
        <asp:CheckBox ID="chkIsActive" runat="server" Enabled="false"></asp:CheckBox>
    </form>
</body>
</html>
