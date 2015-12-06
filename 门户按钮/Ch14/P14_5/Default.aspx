<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P14_5.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table id="Table1" runat="server" border="1" cellpadding="4" cellspacing="2">
      <tr style="font-weight:bold">
        <td>姓名</td> <td>性别</td> <td>年龄</td> <td>Email</td>
      </tr>
      <tr>
        <td>周军</td> <td>男</td> 
        <td>21</td> <td><a href="mailto:zj@a.edu">zj@a.edu</a></td>
      </tr>
      <tr style="background-color:Gray">
        <td>王小红</td> <td>女</td>
        <td>26</td> <td><a href="mailto:wxh@a.edu">wxh@a.edu</a></td>
      </tr>
      <tr>
        <td>方小白</td> <td>男</td>
        <td>24</td> <td><a href="mailto:fxb@a.edu">fxb@a.edu</a></td>
      </tr>
      <tr style="background-color:Gray">
        <td>刘莉</td> <td>女</td>
        <td>19</td ><td><a href="mailto:lil@a.edu">lil@a.edu</a></td>
      </tr>
      <tr>
        <td colspan="4" style="font-size:small">数据采集于2012年12月31日</td>
      </tr>
    </table>
    </div>
    </form>
</body>
</html>
