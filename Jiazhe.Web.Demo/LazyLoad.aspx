<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LazyLoad.aspx.cs" Inherits="Jiazhe.Web.Demo.JS.LazyLoad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
    <script src="JS/jquery.lazyload.js"></script>
    <link rel="stylesheet" href="CSS/ball-spin-clockwise.css" />
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

            #loading img {
                position: absolute;
                top: 50%;
                left: 50%;
                width: 60px;
                height: 60px;
                margin-top: -30px;
                margin-left: -30px;
                background: white;
            }
    </style>
</head>
<body>

<%--<div  class="la-ball-spin-clockwise la-dark la-3x">
    <div></div>
    <div></div>
    <div></div>
    <div></div>
    <div></div>
    <div></div>
    <div></div>
    <div></div>
</div>--%>
<script>
 $(function() {

      $("img.lazyload").lazyload({effect: "fadeIn"});

    });

 $(function () {
            var loading = '<div  class="la-ball-spin-clockwise la-dark la-3x loading"><div></div><div></div><div></div><div></div><div></div><div></div><div></div><div></div></div>';
            $('body').append($(loading));
            $(".data-demo").hide();
            setTimeout(function () {
                $('.la-ball-spin-clockwise').remove();
                $(".data-demo").show();
     }, 3000);
     //$(".data-demo").show();
    });

//    $(function hide() {

//        $(".data-demo").hide();

//    });
//setTimeout("show()", 3500);
//    $(function show() {

//        $(".data-demo").show();

//    });

</script>
<form id="form1" runat="server">
        <div class="data-demo">
            <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound" OnItemCreated="Repeater1_ItemCreated">
            <%--正常显示的数据 奇数行--%>
            <ItemTemplate>
                <tr class="goods-sid"><td colspan="1" style="border-top:1px solid #d4e7ff"></td></tr>
                <tr class=" with-sid mobile-noedit-first" style="border:1px solid #ccc" id="itl" runat="server">
                    <td class="photo">
                        <a target="_blank" href="<%#DataBinder.Eval(Container.DataItem,"ItemUrl") %>" title="<%#DataBinder.Eval(Container.DataItem,"Title") %>">
                            <img class = "lazyload" data-original ="<%# Eval("PictUrl") %>"  width="500" height="500" />
                        </a>
                    </td>
                   
                </tr>
            </ItemTemplate>
            <%-- 交替项显示的数据 偶数行 --%>
            <%--<AlternatingItemTemplate>
                 <tr class=" with-sid mobile-noedit-first" style="border:1px solid #ccc" id="att" runat="server">
                  <td class="photo">
                        <a target="_blank" href="<%#DataBinder.Eval(Container.DataItem,"ItemUrl") %>" title="<%#DataBinder.Eval(Container.DataItem,"Title") %>">
                            <img class = "lazyload" src="<%# Eval("PictUrl") %>" origianal="<%# Eval("NumIid") %>"  class="item-pic" />
                        </a>
                    </td>
                   
                 </tr>
            </AlternatingItemTemplate>--%>
            <%-- 页眉 --%>
            <HeaderTemplate>
            <tr>
                <td class="hdr" colspan="2" style="text-align:center;vertical-align:middle">宝贝名称</td>
                
            </tr>
            </HeaderTemplate>
            <%-- 页脚 --%>
            <FooterTemplate>
                <%--<tr>
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
                </tr>--%>
                
            </FooterTemplate>
            <%-- 分隔 --%>
            <SeparatorTemplate></SeparatorTemplate>
        </asp:Repeater>
        </div>
    </form>
</body>
</html>
