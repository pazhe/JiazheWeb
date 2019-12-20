<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="J_Promo.ascx.cs" Inherits="Jiazhe.Web.Controls.J_Promo" %>
<div id="promo" class="gw-critical-content" style="margin-top: 0px; margin-left: 10px;">

	<style>
<!--
.cc-lm-tcgShowContainer {font-size: 13px;font-family: arial,helvetica,sans-serif;font-weight: normal;text-decoration: none;zoom: 1;}
.cc-lm-tcgShowContainer {margin: 0px; width:auto; overflow:hidden; position:relative;}
.cc-lm-tcgShowContainer img{border:0;}

#cc-lm-tcgShowImgContainer {margin:auto; position: relative; top:0; left:0; overflow:hidden;width:auto;height:100%;}
.cc-lm-tcgImgItem {position:absolute; top:0px;height:100%;width:3600px;left:50%; margin-left:-1800px; text-align:center;background-position:center;background-repeat:no-repeat;}

#cc-lm-tcgShowIndicatorContainer {width:auto; height:3px;position:relative;}
#cc-lm-tcgShowIndicatorBackground {width:auto; height:3px;font-size:0;position:relative; filter:alpha(Opacity=60);-moz-opacity:0.6;opacity: 0.6; background-color:#000000;}
#cc-lm-tcgShowIndicator {position:absolute; left:0; top:0; height:3px;background-color:#FF8C00;font-size:0;}

#cc-lm-WordSepLine {filter:alpha(Opacity=60);-moz-opacity:0.6;opacity: 0.6; background-color:#000000;}
#cc-lm-WordSepLine li{margin:0;padding:0;display:inline-block;height:100%;border:0;border-right:1px solid #FFF;filter:alpha(Opacity=60);-moz-opacity:0.6;opacity: 0.6;}
#cc-lm-navItems li.on {background-color:#FF8C00;}
#cc-lm-navItems li span{font-size:13px;font-style:normal;color:#FFFFFF;}
#cc-lm-navItems li.on span{font-weight:bold;}

#cc-lm-prevItem {cursor:pointer;background-image:url('https://images-cn.ssl-images-amazon.com/images/G/28/gwfloor/static/images/arrow-l._CB349916960_.png');_filter:progid:DXImageTransform.Microsoft.AlphaImageLoader(src='https://images-cn.ssl-images-amazon.com/images/G/28/gwfloor/static/images/arrow-l._CB349916960_.png');background-repeat:no-repeat; background-position:center;}
#cc-lm-nextItem {cursor:pointer;background-image:url('https://images-cn.ssl-images-amazon.com/images/G/28/gwfloor/static/images/arrow-r._CB349916960_.png');_filter:progid:DXImageTransform.Microsoft.AlphaImageLoader(src='https://images-cn.ssl-images-amazon.com/images/G/28/gwfloor/static/images/arrow-r._CB349916960_.png');background-repeat:no-repeat; background-position:center;}

.cc-lm-tcgShowContainer {height:300px; margin-top:0px; margin-bottom:0px;}
#cc-lm-tcgShowIndicator {width:100%;}
#cc-lm-WordSepLine li{width:100%;}
#cc-lm-navItems li{width:100%;}

#cc-lm-tcgShowIndicatorContainer,#cc-lm-tcgShowIndicatorBackground,#cc-lm-tcgShowIndicator {height:3px;}
.cc-lm-tcgShowAdsIndicatorClass {position:absolute;bottom:10px;right:6px;height:10px;width:30px;z-index:50;color:black;}
-->
#adv-float-div {PADDING:1px 1px 0px 1px;FONT-SIZE:12px;Z-INDEX:300;BACKGROUND:#b2b2b2;FLOAT:right;OVERFLOW:hidden;WIDTH:30px;RIGHT:0px;TOP:162px;text-align:center;POSITION:fixed;color:white;display:none;filter:alpha(opacity=70);-moz-opacity:0.7;opacity:0.7;font-family:'Noto Sans'}
</style>

	<div class="promo-bd cc-lm-tcgShowContainer" id="promo-list">   
		<div class="promo-list" id="cc-lm-tcgShowImgContainer promo-list">

		    <div class="cc-lm-tcgImgItem mod" style="display: block;opacity: 1;">
	            <a href="#" aria-label="Click here to view detail" target="_blank">
                    <img src="../Images/Banners/1500x300/1.jpg" alt="click to view detail">
	            </a> 
		    </div>
					  
		    <div class="cc-lm-tcgImgItem mod" style="display: none;">
                <a href="#" target="_blank">
                    <img  width="" height="" src="../Images/Banners/1500x300/2.jpg">
		        </a>
		    </div>
					  
		    <div class="cc-lm-tcgImgItem mod" style="display: none;">
                <a href="#" target="_blank">
                    <img  width="" height="" src="../Images/Banners/1500x300/3.jpg">
                </a>
		    </div>
					  
		    <div class="cc-lm-tcgImgItem mod" style="display: none;">
                <a href="#" target="_blank">
                    <img width="" height="" src="../Images/Banners/1500x300/4.jpg">
                </a>
		    </div>

            <div class="cc-lm-tcgImgItem mod" style="display: none;">
                <a href="#" target="_blank">
                    <img width="" height="" src="../Images/Banners/1500x300/5.jpg">
                </a>
            </div>
					  
		    <div class="cc-lm-tcgImgItem mod" style="display: none; opacity: 1;">
                <a href="#" target="_blank">
                    <img width="" height="" src="../Images/Banners/1500x300/6.jpg">
                </a>
		    </div>
					  
		    <div class="cc-lm-tcgImgItem mod" style="display: none; opacity: 1;">
                <a href="#" target="_blank">
                    <img  width="" height="" src="../Images/Banners/1500x300/7.jpg">
                </a>
		    </div>
					  
			<div class="cc-lm-tcgImgItem mod" style="display: none;">
                <a href="#" target="_blank">
                    <img  width="" height="" src="../Images/Banners/1500x300/8.jpg">
                </a>
			</div>

		</div>
		
	</div>

	<div class="promo-ft a-all" style="position:relative;top: -300px;background-color:transparent;font-size:0;height:0;overflow:visible;">
        <div class="showAds"><span>广告</span></div>
        <div class="promo-opt J_PromoOpt a-all sld-ft-opt">
		<div style="position:absolute; top: 130px; left: -0.5px; display: block; width: 20px; height:30px;" id="cc-lm-prevItem">
            <a id="promo-prev" class="J_Prev prev a-all"><i class="s-prev tb-ifont"></i></a>
		</div>

		<div style="position:absolute; top: 130px; right: -0.5px; display: block; width: 20px; height:30px;" id="cc-lm-nextItem">
            <a id="promo-next" class="J_Next next a-all"><i class="s-next tb-ifont"></i></a>
		</div>
        </div>

        <ul id="promo-buttons" class="promo-nav sld-ft-nav">
            <li index="0"  class="on" ><a>0</a></li>
            <li index="1"><a>1</a></li>
            <li index="2"><a>2</a></li>
            <li index="3"><a>3</a></li>
            <li index="4"><a>4</a></li>
            <li index="5"><a>5</a></li>
            <li index="6"><a>6</a></li>
            <li index="7"><a>7</a></li>
        </ul>
	</div>  	
    
</div>