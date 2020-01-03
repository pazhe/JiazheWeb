<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="J_Member.ascx.cs" Inherits="Jiazhe.Web.Controls.J_Member" %>
<div class="tbh-member J_Module">
    <div class="member" style="display:block">
        <div class="member-bd">
            <div class="avatar-wrapper">
                <a class="J_MemberHome member-home" href="javascript:;" target="_blank">
                    <img class="J_MemberAvatar member-avatar" src="//wwc.alicdn.com/avatar/getAvatar.do?userNick=&width=50&height=50&type=sns&_input_charset=UTF-8" />
                </a>
            </div>
            <span class="member-nick-info">Hi!<strong class="J_MemberNick member-nick">你好</strong></span>
            <p class="member-tjb">
                <a data-spm="d3" href="#" class="J_MemberPunch h">
                <span class="tbh-icon"></span>领淘金币抵钱
                </a>
                <a class="J_MemberClub h club" href="#"><span class="tbh-icon"></span>会员俱乐部</a>
            </p>
        </div>

        <div class="member-ft">
            <div class="member-logout J_MemberLogout" data-spm-ab="2" data-spm-ab-max-idx="3">
                <a href="#" class="btn-login ml1 tb-bg weight">登录</a>
                <a href="#" class="ml2 tb-bg weight">注册</a>
                <a href="#" class="ml3 tb-bg weight">开店</a>
            </div>
        </div>
    </div>
</div>