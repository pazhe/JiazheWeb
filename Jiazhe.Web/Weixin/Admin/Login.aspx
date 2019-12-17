<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Jiazhe.Web.Weixin.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="text-align:center;">
    <script language="javascript">
            if (top.location != self.location){     
            top.location=self.location;     
            }
  </script>
    <form id="form1" runat="server">
        <div style="height:300px;"></div>
        <div style="margin:0 auto;width:300px;height:100px;top:200px;">
            
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
