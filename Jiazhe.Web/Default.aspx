<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Jiazhe.Web.Default" %>

<%@ Register Src="~/Controls/J_SiteNav.ascx" TagPrefix="uc" TagName="J_SiteNav" %>
<%@ Register Src="~/Controls/J_SuperBanner.ascx" TagPrefix="uc" TagName="J_SuperBanner" %>
<%@ Register Src="~/Controls/J_Top.ascx" TagPrefix="uc" TagName="J_Top" %>
<%@ Register Src="~/Controls/J_Nav.ascx" TagPrefix="uc" TagName="J_Nav" %>
<%@ Register Src="~/Controls/J_Service.ascx" TagPrefix="uc" TagName="J_Service" %>
<%@ Register Src="~/Controls/J_Promo.ascx" TagPrefix="uc" TagName="J_Promo" %>
<%@ Register Src="~/Controls/J_Tmall.ascx" TagPrefix="uc" TagName="J_Tmall" %>
<%@ Register Src="~/Controls/J_Promo1.ascx" TagPrefix="uc" TagName="J_Promo1" %>
<%@ Register Src="~/Controls/J_Tmall_SubColumn.ascx" TagPrefix="uc" TagName="J_Tmall_SubColumn" %>
<%@ Register Src="~/Controls/J_Member.ascx" TagPrefix="uc" TagName="J_Member" %>
<%@ Register Src="~/Controls/J_Tipoff.ascx" TagPrefix="uc" TagName="J_Tipoff" %>
<%@ Register Src="~/Controls/J_Notice.ascx" TagPrefix="uc" TagName="J_Notice" %>
<%@ Register Src="~/Controls/J_Conve.ascx" TagPrefix="uc" TagName="J_Conve" %>
<%@ Register Src="~/Controls/J_App.ascx" TagPrefix="uc" TagName="J_App" %>







<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Styles/Css/Default/Default.css" type="text/css" rel="stylesheet" />
    <link href="Styles/Css/Default/Controls.css" type="text/css" rel="stylesheet" />
    <link href="//at.alicdn.com/t/font_1595702_i2cjlcva8e8.css" type="text/css" rel="stylesheet" />

    <script src="//at.alicdn.com/t/font_1595702_i2cjlcva8e8.js" type="text/javascript"></script>
    <script src="JS/jquery/jquery.signalR-1.1.4.min.js" type="text/javascript"></script>
    <script src="JS/jquery/jquery.lazyload.js" type="text/javascript"></script>
    <script src="JS/main.js" type="text/javascript"></script>
    <title></title>
</head>
<body>
  <form id="form" runat="server">  

    <div class="cover J_Cover">
        <uc:J_SiteNav runat="server" id="J_SiteNav" />
        <uc:J_SuperBanner runat="server" id="J_SuperBanner" />
    </div>
    <div class="cup J_Cup">
        <uc:J_Top runat="server" id="J_Top" />
    </div>
    <div class="tbh-nav J_Module tb-pass">
        <uc:J_Nav runat="server" ID="J_Nav" />
    </div>

    <div class="screen-outer clearfix" id="pageContent">
        <div class="main" id="main" style="width:100%">
            <div class="main-inner clearfix bd" id="main-inner">
                <div class="tbh-service J_Module"><%--左侧类目--%><uc:J_Service runat="server" id="J_Service" /></div>
                <div class="core J_Core" id="core">
                    <div class="tbh-promo J_Module"><%--轮播--%>
                        <%--<uc:J_Promo1 runat="server" id="J_Promo1" />--%>
                        <uc:J_Promo runat="server" id="J_Promo" />

                    </div>
                    <div class="tbh-tmall clearfix">
                        <%--轮播下面广告--%>
                        <uc:J_Tmall runat="server" id="J_Tmall" />
                        <uc:J_Tmall_SubColumn runat="server" id="J_Tmall_SubColumn" />
                    </div>
                </div>
                <div class="sub-column" style="display:none;">中间旁边广告</div>
                <div class="col-right" id="col-right" style="display:block;" >
                    <uc:J_Member runat="server" id="J_Member1" />
                    <uc:J_Tipoff runat="server" id="J_Tipoff1" />
                    <uc:J_Notice runat="server" id="J_Notice1" />
                    <uc:J_Conve runat="server" id="J_Conve1" />
                    <uc:J_App runat="server" id="J_App1" />
                </div>
            </div>
        </div>
    </div>

    <div style="width:100%; float:left"><a href="Weixin/Admin/index.html" target="_blank">微信后台管理员登录</a><a href="Manager/index.html" target="_blank">网站后台管理员登录</a></div>
    <script>
        document.getElementById("core").style.width = 800+"px;";
</script>



  </form>


</body>
</html>
