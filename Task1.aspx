<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task1.aspx.cs" Inherits="ViewStateTask1.Task1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="text" runat="server" id="txt"/>
            <asp:Button type="button" runat="server" Text="Click Me" onclick="Btn_Click" />
        </div>
    </form>
</body>
</html>
