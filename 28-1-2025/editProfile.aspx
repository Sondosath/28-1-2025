<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editProfile.aspx.cs" Inherits="_28_1_2025.editProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Profile</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Edit Profile</h3>
            <label>Name:</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
            <label>Email:</label>
            <asp:TextBox ID="txtEmail" runat="server" ReadOnly="true"></asp:TextBox><br />
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </div>
    </form>
</body>
</html>