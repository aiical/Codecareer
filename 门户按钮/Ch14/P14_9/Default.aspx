<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P14_9.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="~/pic/computer.jpg">
      <asp:RectangleHotSpot Left="275" Top="5" Right="430" Bottom="290" NavigateUrl="http://www.lenovo.com.cn" AlternateText="联想电脑"/>
      <asp:PolygonHotSpot Coordinates="128,53,103,209,263,229,274,32" NavigateUrl="http://lcd.zol.com.cn" AlternateText="显示器" />
      <asp:PolygonHotSpot Coordinates="5,250,69,233,215,270,150,308" NavigateUrl="http://product.pconline.com.cn/keyboard" AlternateText="键盘"/>
      <asp:CircleHotSpot X="240" Y="290" Radius="35" NavigateUrl="http://mouse.zol.com.cn" AlternateText="鼠标"/>
    </asp:ImageMap>
    </div>
    </form>
</body>
</html>
