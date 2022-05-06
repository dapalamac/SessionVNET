<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="SessionVNET._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>

            Name: <asp:TextBox ID="NameTextBox" runat="server"/><br />

            Date Of Birth: <asp:TextBox ID="DOBTextBox" runat="server"/><br />

            <asp:Button ID="NextPageButton" text="Go To Next Page" runat="server" />

        </div>
    </form>
</body>
</html>


