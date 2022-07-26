<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Task2.aspx.cs" Inherits="ViewStateTask2.Task2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function SaveData() {
            var fname = document.getElementById("fName");
            var sname = document.getElementById("sName");
            
            var a = document.getElementById("hiddenfName");
            var b = document.getElementById("hiddensName");
            a.value = fname.value;
            b.value = sname.value;
           
            return True;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           First Name:<input type="text" runat="server" id="fName" /><br />
           Second Name:<input type="text" runat="server" id="sName" /><br />
            <input type="hidden" id="hiddenfName" runat="server" value=""  /><br />
            <input type="hidden" id="hiddensName" runat="server" value=""/><br />
            <asp:Button type="button" runat="server" Text="Submit" ID="submit" OnClientClick=" return SaveData()" OnClick ="submit_Click" />
            <asp:Button type="button" runat="server" Text="Restore Via ViewState" ID="viewState" OnClick="ViewState_Click" />
            <asp:Button type="button" runat="server" Text="Restore Via Hidden Field" ID="TohiddenField" OnClick="HiddenField_Click" />
        </div>

    </form>
</body>
</html>
