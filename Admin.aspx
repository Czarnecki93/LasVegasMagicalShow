<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="LasVegasMagicalShow.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label_login" runat="server" Text="Loginlabel"></asp:Label>
        </div>
        <br />
        <br />
        <asp:ListBox ID="ListBoxUsers" runat="server" Height="208px" Width="761px"></asp:ListBox>
    </form>
</body>
</html>
