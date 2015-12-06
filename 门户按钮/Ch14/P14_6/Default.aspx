<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P14_6.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        搜索领域(多选):<br/> 
        <input type="checkbox" id="CheckBox1" runat="server" onserverchange= "RC_Change"/>Windows开发
        <input type="checkbox" id="CheckBox2" runat="server" onserverchange= "RC_Change"/>网站开发
        <input type="checkbox" id="CheckBox3" runat="server" onserverchange= "RC_Change"/>数据库开发
        <br />使用语言(单选):<br/>
        <input type="radio" id="Radio1" runat="server" onserverchange= "RC_Change"/>C#
        <input type="radio" id="Radio2" runat="server" onserverchange= "RC_Change" />VB
        <br/><input id="Image1" type="image" runat="server" src="search.bmp" alt="搜索"/>
        <textarea id="TextArea1" runat="server" cols="30" rows="5"></textarea>
    </div>
    </form>
</body>
</html>
