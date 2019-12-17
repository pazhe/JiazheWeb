<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Favorites.aspx.cs" Inherits="Jiazhe.Web.Manager.Pages.Favorites" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

</head>
<body>
    管理员：<asp:Label ID="lblConsumerName" runat="server" Text="Label"></asp:Label>
    <form id="form1" runat="server">
        <asp:Button id="updateAllFavorites" runat="server" Text="更新选品库" OnClick="updateAllFavorites_Click"></asp:Button>
        <asp:Button id="updateAllFavoritesItems" runat="server" Text="批量更新选品库产品" OnClick="updateAllFavoritesItems_Click"></asp:Button>
        <asp:DataGrid id="DataGrid1" runat="server" AutoGenerateColumns="False" BorderColor="#3366CC"
								BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4" Width="870px" Height="207px" OnUpdateCommand="DataGrid1_UpdateCommand" AllowPaging="True" AllowSorting="True" OnPageIndexChanged="DataGrid1_PageIndexChanged" PageSize="20" OnItemDataBound="DataGrid1_ItemDataBound" OnSortCommand="DataGrid1_SortCommand" style="margin-top: 3px" ShowFooter="True">
								<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
								<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
								<ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
								<Columns>
									<asp:BoundColumn DataField="FavoritesId" HeaderText="选品库id" SortExpression="FavoritesId"></asp:BoundColumn>
									<asp:BoundColumn DataField="FavoritesTitle" HeaderText="选品库名称"></asp:BoundColumn>
									<asp:BoundColumn DataField="Type" HeaderText="选品库类型"></asp:BoundColumn>
                                    <%--<asp:BoundColumn DataField="total_results" HeaderText="产品数量"></asp:BoundColumn>--%>
									<asp:ButtonColumn Text="更新" CommandName="update" HeaderText="更新"></asp:ButtonColumn>
									<asp:TemplateColumn HeaderText="全选">
                                        <FooterTemplate>
                                            <asp:DropDownList ID="ddlPageSize" runat="server" CssClass="ddlPageSize" style="z-index: 1" OnSelectedIndexChanged="ddlPageSize_SelectedIndexChanged">
                                                <asp:ListItem>30</asp:ListItem>
                                                <asp:ListItem>50</asp:ListItem>
                                                <asp:ListItem>100</asp:ListItem>
                                            </asp:DropDownList>
                                        </FooterTemplate>
                                        <HeaderTemplate>全选<asp:CheckBox id="chkSelectAll" runat="server" OnCheckedChanged="chkSelectAll_CheckedChanged" AutoPostBack="true"></asp:CheckBox></HeaderTemplate>
										<ItemTemplate>
											<asp:CheckBox id="chkSelect" runat="server"></asp:CheckBox>
										</ItemTemplate>
									</asp:TemplateColumn>
                                    <asp:HyperLinkColumn DataNavigateUrlField="FavoritesId" DataNavigateUrlFormatString="FavoriteItems.aspx?FavoritesId={0}" HeaderText="详情" Text="详情"></asp:HyperLinkColumn>
								</Columns>
								<PagerStyle HorizontalAlign="Left" ForeColor="#003399" BackColor="#99CCCC" Mode="NumericPages"></PagerStyle>
							</asp:DataGrid>
    </form>
</body>
</html>
