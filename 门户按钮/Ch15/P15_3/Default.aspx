<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P15_3.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        省份:<asp:DropDownList ID="DropDownList1" runat="server" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="查询" Width="80" onclick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text=">>" Width="50" onclick="Button2_Click" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" />        
    </div>
    </form>
</body>
</html>
