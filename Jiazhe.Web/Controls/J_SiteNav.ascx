<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="J_SiteNav.ascx.cs" Inherits="Jiazhe.Web.Controls.J_SiteNav" %>
<div id="site-nav" class="site-nav" style="background: #F2F2F2; width: 100%;height: 35px">

    <div class="site-nav-bd site-nav-status-login bd" id="J_SiteNav" style="margin-left: auto; margin-right: auto;">
        <!--site-nav-bd-left-->
        <ul class="site-nav-bd-left">
           
                <asp:Panel ID="PanelLogin" runat="server" CssClass="panelLogin">
                    <li class="menu sigin">
                        <a style="color: #f22e00" href="../Member/Login.aspx" target="_self">请登录</a><span class="top_line">|</span>
                    </li>
                    <li class="menu register">
                        <a href="Register.aspx" target="_self">免费注册</a><span class="top_line">|</span>
                    </li>
                </asp:Panel>
                <asp:Panel ID="PanelMember" runat="server" Visible="False" CssClass="panelMember">
                    <li class="menu sigin">
                        <asp:Label ID="menu_sigin" runat="server" Text="请登录"></asp:Label><span class="top_line">|</span>
                    </li>
                    <li class="menu register">
                        <asp:LinkButton ID="lbtnLogOut" runat="server" >安全退出</asp:LinkButton><span class="top_line">|</span>
                    </li>
                </asp:Panel>
            <li class="menu collection">
                <a href="#"><span class="g_icon">★</span>收藏夹</a> <span class="top_line">|</span>
            </li>
            <li class="menu mobile">
                <a href="#">手机逛</a>
            </li>
        </ul>
        <!--site-nav-bd-left-end-->
        <ul class="site-nav-bd-right">
            <li class="menu sigin">
                <a style="color:#f22e00" href="#">我的试用</a><span class="top_line">|</span>
            </li>
            <li class="menu register">
                <a href="#">邀请好友</a><span class="top_line">|</span>
            </li>
            <li class="menu sigin">
                <a href="#">问卷调查</a><span class="top_line">|</span>
            </li>
            <li class="menu register">
                <a href="#">帮助中心</a><span class="top_line">|</span>
            </li>
            <li class="menu sigin">
                <a style="color:#f22e00" href="#">在线客服</a><span class="top_line">|</span>
            </li>
            <li class="menu register">
                <a href="#">网站导航</a>
            </li>
        </ul>
         <!--header_right-->
    </div>
    <!--site-nav-bd-->
</div>