<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_111_1HW5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_Insert" runat="server" Text="點我新增資料夾" OnClick="btn_Insert_Click" />
            <asp:GridView ID="gd_View" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
