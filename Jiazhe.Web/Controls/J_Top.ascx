<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="J_Top.ascx.cs" Inherits="Jiazhe.Web.Controls.J_Top" %>
<div class="top J_Top" style=" width:100%;">

    <div class="top-wrap clearfix bd" style="overflow:hidden; background-color:#fff;">

        <%-- 左侧logo模块 --%>
        <div class="tbh-logo J_Module tb-pass" style="width:20%">
            <div class="logo">
                <h1>
                    <a href="#" style="display:none" class="logo-bd clearfix">稻草人网</a>
                    <a href="#" target="_blank" class="logo-hover">
                        <img src="../Images/Logo/logo.png" />
                    </a>
                </h1>
                <h2 style="display:none"><a class="clearfix" href="#" ></a>稻草人网</h2>
            </div>
        </div>
        
        <%--中间搜索模块  --%>
        <div class="tbh-search J_Module"  style="margin-left:25%; margin-right:25%; width:50%">
            <div class="search-wrap">
                <div class="search-bd">
                    <div id="J_SearchTab" style="margin-left:20px;height:22px;" class="search-triggers search-tab-header J_SearchTabBox">
                        <ul class="ks-switchable-nav">
                            <li class="J_SearchTab selected goods-search-tab" >宝贝</li>
                            <li class="J_SearchTab tmall-search-tab">天猫</li>
                            <li class="J_SearchTab shop-search-tab">店铺</li>
                        </ul>
                        <div class="search-tab-icon"><i><em></em><span></span></i></div>
                    </div>
                    <%--J_SearchTab end--%>
                    <div class="search-panel search-hp-panel ks-switchable-content J_SearchPanel"; style="position:relative;">
                        <%--<form action="//s.taobao.com/search" name="search" id="J_TSearchForm">--%>
                            <div class="search-button">
                                <asp:Button ID="Button1"  CssClass="btn-search tb-bg" runat="server" Text="搜索"/>
                            </div>
                            <div class="search-panel-fields search-hp-fields search-common-panel">
                                <div class="J_TbSearchContent J_TbPlaceholder J_Placeholder search-combobox-placeholcer" id="tbSearchContent">
                                </div>
                                <div class="search-combobox">
                                    <div class="search-combobox-input-wrap">
                                        <asp:TextBox ID="TextBox1" CssClass="q" runat="server">123123</asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        <%--</form>--%>
                    </div>
                    <%--J_SearchPanel end--%>
                </div>

                <div class="search-ft J_SearchFt clearfix">
                    <div class="J_TbSearchContent J_HotWord">
                        <div class="search-hots">
                            <div class="search-hots-lines">
                                <div class="search-hots-fline">
                                    <a href="#">新款连衣裙</a>
                                    <a href="#">四件套</a>
                                    <a href="#">潮流T恤</a>
                                    <a href="#">短裤</a>
                                    <a href="#" class="h">时尚女鞋</a>

                                    <a href="#">半身裙</a>
                                    <a href="#">男士外套</a>
                                    <a href="#">行车记录仪</a>
                                    <a href="#">新款男鞋</a>
                                    <a href="#" class="h">耳机</a>

                                    <a href="#">时尚女包</a>
                                    <a href="#">沙发</a>
                                    <a href="#">行车记录仪</a>
                                    <a href="#">新款男鞋</a>
                                    <a href="#" class="h">耳机</a>

                                    <a href="#">新款连衣裙</a>
                                    <a href="#">四件套</a>
                                    <a href="#" class="h">潮流T恤</a>
                                    <a href="#">短裤</a>
                                    <a href="#">时尚女鞋</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <%-- 右侧banner --%>
        <div class="tbh-qr-wrapper" style="width:20%">
            <div class="tbh-qr J_Module">
                <div class="play-11">
                    <a href="#" class="play-normal" style="top:-20px;
                        background-repeat:no-repeat;background-image:url(https://gw.alicdn.com/tfs/TB1nSUAouT2gK0jSZFvXXXnFXXa-120-120.png);"></a>
                </div>
            </div>
        </div>

    </div>
</div> 