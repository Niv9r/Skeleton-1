<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffConfirmDelete.aspx.cs" Inherits="AdminSystem.Staff.StaffConfirmDelete" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Confirm Staff Deletion</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Confirm Staff Deletion</h2>
        <asp:Label ID="lblStaffID" runat="server" Text="Staff ID:" AssociatedControlID="txtStaffID"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" ReadOnly="true"></asp:TextBox>
        <br /><br />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="BtnCancel_Click" />
    </form>
</body>
</html>
