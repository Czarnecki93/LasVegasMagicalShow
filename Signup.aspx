<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="LasVegasMagicalShow.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            USERNAME:
            <asp:TextBox ID="TextBox_sp_username" runat="server"></asp:TextBox>
            <br />
            PASSWORD:
            <asp:TextBox ID="TextBox_sp_password" runat="server"></asp:TextBox>
            <br />
            <br />
            I AM A:<br />
            <asp:RadioButtonList ID="RadioButtonList_usertype" runat="server">
                <asp:ListItem>Magician</asp:ListItem>
                <asp:ListItem>Staff member</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <asp:Button ID="Button_sp_signup" runat="server" OnClick="Button_sp_signup_Click" Text="SIGNUP" />
        </div>
    </form>
</body>
</html>
