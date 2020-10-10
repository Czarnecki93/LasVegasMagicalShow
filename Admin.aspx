<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="LasVegasMagicalShow.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label_login" runat="server" Text="Login text label"></asp:Label>
        </div>
        &nbsp;<br />
&nbsp;<br />
        Your info:<br />
        <asp:Label ID="Userinfo" runat="server" Text="Userinfo label"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        New name<br />
        <asp:TextBox ID="TextBoxPass" runat="server"></asp:TextBox>
        New password<br />
        <asp:TextBox ID="TextBoxSal" runat="server"></asp:TextBox>
        New salary<br />
        <br />
        <asp:Button ID="ButtonUpdate" runat="server" OnClick="ButtonUpdate_Click" Text="Update info" />
        <br />
        <br />
        List of other users:<br />
        <asp:ListBox ID="ListBoxUsers" runat="server" Height="208px" Width="761px"></asp:ListBox>
    </form>
</body>
</html>
