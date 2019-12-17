<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Jiazhe.Web.Manager.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
    <link rel="stylesheet" href="../Styles/Css/Loding/ball-spin-clockwise.css"/>
     <style>

        .loading {
            position: fixed;
            top: 50%;
            left: 50%;
            width: 100%;
            height: 100%;
            opacity: 0.6;
            z-index: 15000;
            }
    </style>
</head>
<body style="text-align:center;">
<script>

    if (top.location != self.location){     
    top.location=self.location;     
    }

 $(function () {
            var loading = '<div  class="la-ball-spin-clockwise la-dark la-3x loading"><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div></div>';
            $('body').append($(loading));
            $(".data-demo").hide();
            setTimeout(function () {
                $('.la-ball-spin-clockwise').remove();
                $(".data-demo").show();
     }, 300);
    });
</script>

    <form id="form1" runat="server">
        <div style="height:300px;"></div>
        <div class="data-demo" style="margin:0 auto;width:300px;height:100px;top:200px;">
            
            <table >
                <tr>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text="用户名："></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td ><asp:Label ID="lblPwd" runat="server" Text="密&nbsp;码："></asp:Label></td>
                    <td ><asp:TextBox ID="txtPwd" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnReset" runat="server" Text="重置" OnClick="btnReset_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSub" runat="server" Text="登录" OnClick="btnSub_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
