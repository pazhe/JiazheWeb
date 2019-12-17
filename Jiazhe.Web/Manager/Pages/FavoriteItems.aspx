<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FavoriteItems.aspx.cs" Inherits="Jiazhe.Web.Manager.Pages.FavoriteItems" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="../../Styles/Css/Manager/FavoriteItems.css" />
    <link rel="stylesheet" href="../../Styles/Css/Default/Default.css" />
    <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
    <script  src="../../JS/jquery/jquery.lazyload.js"></script>
    <script  src="../../JS/main.js"></script>
    <title></title>
</head>
<body>
 <form id="form1" runat="server">
    <div style="margin-left:10px;">
        <table style="font-size:12px;">
        <%--Repeater循环显示数据--%>
        <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound" OnItemCreated="Repeater1_ItemCreated">
            <%--正常显示的数据 奇数行--%>
            <ItemTemplate>
                <tr class="goods-sid"><td colspan="10" style="border-top:1px solid #d4e7ff"></td></tr>
                <tr class=" with-sid mobile-noedit-first" style="border:1px solid #ccc" id="itl" runat="server">
                    <td class="photo">
                        <a target="_blank" href="<%#DataBinder.Eval(Container.DataItem,"ItemUrl") %>" title="<%#DataBinder.Eval(Container.DataItem,"Title") %>">
                            <img class = "lazyload item-pic" data-original ="<%# Eval("PictUrl") %>" width="80" height="80" />
                        </a>
                    </td>
                    <td>
                        <div class="item-title-area" style="width:220px;">
                            <p><a class="item-title" target="_blank" href="<%#DataBinder.Eval(Container.DataItem,"ItemUrl") %>" title="<%#DataBinder.Eval(Container.DataItem,"Title") %>">
                                <%#DataBinder.Eval(Container.DataItem,"Title") %> 
                               </a></p>
                        </div>
                        <div class="item-cate">
                            <img class="J_QRCode" data-param="itemId=576682939661&amp;cid=50050397&amp;title=<%#DataBinder.Eval(Container.DataItem,"Title") %>"  src="../../Images/Other/code.png" alt="宝贝电子二维码" border="0">
                        </div>
                        id:<%# Eval("NumIid") %></td>
                    <td class="reserve_price"><p style="width: 100px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"ReservePrice") %></p></td>
                    <td class="zk_final_price"><p style="width: 100px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"ZkFinalPrice") %></p></td>
                    <td class="volume"><p style="width: 100px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"Volume") %></p></td>
                    <td class="tk_rate"><p style="width: 100px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"TkRate") %></p></td>
                    <td class="status"><p style="width: 50px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"Status") %></p></td>
                    
                    <td class="coupon_info"><p style="width: 100px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"CouponInfo") %></p></td>
                    <td class="coupon_total_count"><p style="width: 100px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"CouponTotalCount") %></p></td>
                    <td class="coupon_remain_count"><p style="width: 100px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"CouponRemainCount") %></p></td>
                    
                </tr>
            </ItemTemplate>
            <%-- 交替项显示的数据 偶数行 --%>
            <AlternatingItemTemplate>
                 <tr class=" with-sid mobile-noedit-first" style="border:1px solid #ccc" id="att" runat="server">
                  <td class="photo">
                        <a target="_blank" href="<%#DataBinder.Eval(Container.DataItem,"ItemUrl") %>" title="<%#DataBinder.Eval(Container.DataItem,"Title") %>">
                            <img class = "lazyload item-pic" data-original ="<%# Eval("PictUrl") %>" width="80" height="80" />
                        </a>
                    </td>
                    <td>
                        <div class="item-title-area" style="width:220px;">
                            <p><a class="item-title" target="_blank" href="<%#DataBinder.Eval(Container.DataItem,"ItemUrl") %>" title="<%#DataBinder.Eval(Container.DataItem,"Title") %>">
                                <%#DataBinder.Eval(Container.DataItem,"Title") %> 
                               </a></p>
                        </div>
                        <div class="item-cate">
                            <img class="J_QRCode" data-param="itemId=576682939661&amp;cid=50050397&amp;title=<%#DataBinder.Eval(Container.DataItem,"Title") %>"  src="../../Images/Other/code.png" alt="宝贝电子二维码" border="0">
                        </div>
                        id:<%# Eval("NumIid") %></td>
                    <td class="reserve_price"><p style="width: 100px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"ReservePrice") %></p></td>
                    <td class="zk_final_price"><p style="width: 100px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"ZkFinalPrice") %></p></td>
                    <td class="volume"><p style="width: 100px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"Volume") %></p></td>
                    <td class="tk_rate"><p style="width: 100px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"TkRate") %></p></td>
                    <td class="status"><p style="width: 50px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"Status") %></p></td>
                    
                    <td class="coupon_info"><p style="width: 100px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"CouponInfo") %></p></td>
                    <td class="coupon_total_count"><p style="width: 100px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"CouponTotalCount") %></p></td>
                    <td class="coupon_remain_count"><p style="width: 100px;height: 45px;display: block;line-height: 45px;text-align:center;"><%#DataBinder.Eval(Container.DataItem,"CouponRemainCount") %></p></td>
                     
                 </tr>
            </AlternatingItemTemplate>
            <%-- 页眉 --%>
            <HeaderTemplate>
            <tr>
                <td class="hdr" colspan="2" style="text-align:center;vertical-align:middle">宝贝名称</td>
                <td class="hdr" style="text-align:center;vertical-align:middle">一口价</td>
                <td class="hdr" style="text-align:center;vertical-align:middle">折扣价</td>
                <td class="hdr" style="text-align:center;vertical-align:middle">30天销量</td>
                
                <td class="hdr" style="text-align:center;vertical-align:middle">佣金比例</td>
                <td class="hdr" style="text-align:center;vertical-align:middle;">状态</td>
                <td class="hdr" style="text-align:center;vertical-align:middle;">优惠券面额</td>
                <td class="hdr" style="text-align:center;vertical-align:middle;">优惠券总量</td>
                <td class="hdr" style="text-align:center;vertical-align:middle;">优惠券余量</td>
            </tr>
            </HeaderTemplate>
            <%-- 页脚 --%>
            <FooterTemplate>
                <tr>
                    <td colspan="10">
                        <div style="display:block; float:left;">
                            每页显示&nbsp;&nbsp
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="40"></asp:DropDownList>
                            &nbsp;&nbsp条
                        </div>
                        <div style="display:block; float:right;">
                            <asp:Button ID="btnUp" runat="server" Text="上一页" OnClick="btnUp_Click" />
                            <asp:Label ID="lblNum" runat="server" Text="1" Font-Size="14px"></asp:Label>
                            <asp:Button ID="btnNext" runat="server" Text="下一页" OnClick="btnNext_Click" />
                            第&nbsp;&nbsp
                            <asp:TextBox ID="TextBox1" runat="server" Width="40"></asp:TextBox>
                            &nbsp;&nbsp;页
                            <asp:Button ID="Button1" runat="server" Text="GO" />
                         </div>
                    </td>
                </tr>
                
            </FooterTemplate>
            <%-- 分隔 --%>
            <SeparatorTemplate></SeparatorTemplate>
        </asp:Repeater>
        </table>
    </div>
    </form>
</body>
</html>
