<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style/StyleSheet.css" rel="stylesheet" type="text/css"/>
    <script src="Scripts/jquery-2.1.4.min.js"></script>
    </head>
<body>
    <form id="form1" runat="server">
    <div id ="emailForm" runat="server">
        <h1>Send Mail</h1>
        <p><b>From :</b></p>
        <p><asp:TextBox ID="txtmailfrom" runat="server" /></p>
        <p><b>To :</b></p>
        <p><asp:TextBox ID="txtmailto" runat="server" /></p>
        <p><b>Subject :</b></p>
        <p><asp:TextBox ID="txtmailsubject"  runat="server" /></p>
        <p><b>Body :</b></p>
        <p>
            <asp:TextBox ID="txtText" textmode="MultiLine" Columns="20" Rows="20" runat="server" Height="202px" Width="556px" />
        </p>
        <p>Select your message priority:</p>
        <p>
            <asp:DropDownList ID="msgPriority" runat="server" Width="150px">
                <asp:ListItem>Low</asp:ListItem>
                <asp:ListItem>Normal</asp:ListItem>
                <asp:ListItem>High</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p><asp:Button text="Send" OnClick="Button_Click" runat="server" Height="50px" Width="150px" /></p>
        </div>
    </form>
</body>
</html>
