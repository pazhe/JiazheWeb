<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="J_SuperBanner.ascx.cs" Inherits="Jiazhe.Web.Controls.J_SuperBanner" %>

<div class="tbh-superbanner clearfix" style="width:100%;overflow:hidden;" >
    <div class="superbanner-bar"></div>
    <div class="superbanner-inner bd" style="overflow:hidden;">
        <div class="superbanner-inner-l sup-banner" style="width:70%;">
            <asp:AdRotator ID="AdRotatorLeft" runat="server" AdvertisementFile="~/DataBase/AdvertisementTopLeft.xml" Height="100%" Width="99.25%" OnAdCreated="AdRotatorLeft_AdCreated" />
            <div class="showAds"><span>广告</span></div>
        </div>
        <div class="superbanner-inner-r sup-banner" style="width:30%;">
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/DataBase/AdvertisementTopRight.xml" Height="100%" Width="100%" />
            <div class="showAds"><span>广告</span></div>
        </div>
    </div>
</div>