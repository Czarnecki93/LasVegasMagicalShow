<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="LasVegasMagicalShow.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 338px;
            margin-left: 360px;
            margin-top: 169px;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            margin-left: 0px;
            margin-top: 0px;
        }
    </style>
</head>
<body style="width: 1000px; text-align: justify; height: 502px">
    <form id="form1" runat="server" class="auto-style1">
        <div class="auto-style2">
        <div>
        </div>
    &nbsp;USERNAME&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox_username" runat="server"></asp:TextBox>
            <br />
            <br />
            PASSWORD&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox_password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button_login" runat="server" Text="LOGIN" Width="90px" OnClick="Button_login_Click" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button_signup" runat="server" CssClass="auto-style3" style="text-align: left" Text="SIGNUP" Width="90px" OnClick="Button_signup_Click" />
        </div>
        <asp:ListBox ID="ListBox1" runat="server" Height="203px" Width="750px"></asp:ListBox>
    </form>
</body>
</html>
