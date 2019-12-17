window.onload = function () {
    /*silder();*/  //原生轮播
    promo();
    //getWidth();
}
$(function () {
$("img.demo").lazyload({
    placeholder: "img/grey.gif", //用图片提前占位
    // placeholder,值为某一图片路径.此图片用来占据将要加载的图片的位置,待图片加载时,占位图则会隐藏
    effect: "fadeIn", // 载入使用何种效果
    // effect(特效),值有show(直接显示),fadeIn(淡入),slideDown(下拉)等,常用fadeIn
    threshold: 200, // 提前开始加载
    // threshold,值为数字,代表页面高度.如设置为200,表示滚动条在离目标位置还有200的高度时就开始加载图片,可以做到不让用户察觉
    event: 'click',  // 事件触发时才加载
    // event,值有click(点击),mouseover(鼠标划过),sporty(运动的),foobar(…).可以实现鼠标莫过或点击图片才开始加载,后两个值未测试…
    container: $("#container"),  // 对某容器中的图片实现效果
    // container,值为某容器.lazyload默认在拉动浏览器滚动条时生效,这个参数可以让你在拉动某DIV的滚动条时依次加载其中的图片
    failurelimit: 10 // 图片排序混乱时
    // failurelimit,值为数字.lazyload默认在找到第一张不在可见区域里的图片时则不再继续加载,但当HTML容器混乱的时候可能出现可见区域内图片并没加载出来的情况,failurelimit意在加载N张可见区域外的图片,以避免出现这个问题.
});
});

$(function () {

    $("img.lazyload").lazyload({
        placeholder: "../../Images/Loading/grey-50.gif",
        effect: "fadeIn"
    });

});


//原生轮播图 start
function silder() {
    var container = document.getElementById('silder');
    var list = document.getElementById('list');
    var prev = document.getElementById('prev');
    var next = document.getElementById('next');
    var buttons = document.getElementById('buttons').getElementsByTagName('span');
    var index = 1;
    var timer;
    //获取的是style.left，是相对左边获取距离
    function animate(offset) {
        //获取的是style.left，是相对左边获取距离，所以第一张图后style.left都为负值，
        //且style.left获取的是字符串，需要用parseInt()取整转化为数字。
        var newLeft = parseInt(list.style.left) + offset;
        list.style.left = newLeft + 'px';
        //无限滚动判断
        if (newLeft > -700) {
            list.style.left = -3900 + 'px';
        }
        if (newLeft < -3900) {
            list.style.left = -700 + 'px';
        }
    }
    //重复执行的定时器
    function play() {
        timer = setInterval(function () {
            next.onclick();
        }, 5000)
    }
    function stop() {
        clearInterval(timer);
    }

    //将之前的小圆点的样式清除
    function buttonsShow() {
        //将之前的小圆点的样式清除
        for (var i = 0; i < buttons.length; i++) {
            if (buttons[i].className == "on") {
                buttons[i].className = "";
            }
        }
        //数组从0开始，故index需要-1
        buttons[index - 1].className = "on";
    }
    prev.onclick = function () {
        index -= 1;
        if (index < 1) {
            index = 5
        }
        buttonsShow();
        animate(700);
    };
    next.onclick = function () {
        //由于上边定时器的作用，index会一直递增下去，我们只有5个小圆点，所以需要做出判断
        index += 1;
        if (index > 5) {
            index = 1
        }
        animate(-700);
        buttonsShow();
    };
    for (var i = 0; i < buttons.length; i++) {
        (function (i) {
            buttons[i].onclick = function () {
                /*  这里获得鼠标移动到小圆点的位置，用this把index绑定到对象buttons[i]上，去谷歌this的用法  */
                /*  由于这里的index是自定义属性，需要用到getAttribute()这个DOM2级方法，去获取自定义index的属性*/
                var clickIndex = parseInt(this.getAttribute('index'));
                var offset = 700 * (index - clickIndex); //这个index是当前图片停留时的index
                animate(offset);
                index = clickIndex; //存放鼠标点击后的位置，用于小圆点的正常显示
                buttonsShow();
            }
        })(i)
    }
    container.onmouseover = stop;
    container.onmouseout = play;
    play();
    //原生轮播图 start
}
//原生轮播图 end

function promo() {
    var promo = document.getElementById('promo');
    var list = document.getElementById('promo-list');
    var prev = document.getElementById('promo-prev');
    var next = document.getElementById('promo-next');
    var buttons = document.getElementById('promo-buttons').getElementsByTagName('li');
    var timerHandler = 5000;
    //var main = document.getElementById("main");
    //var mainInner = document.getElementById("main-inner");
    //var promo = document.getElementById("promo");
    //var img = document.getElementById("promo-list").getElementsByTagName("img");

    var index = 0;
    var timer;
    //var width;
    //var percentage;

    //设置显示的图片 index 从1开始传过来
    function showImg(index) {
        if (index > 0) {
            list.getElementsByClassName("mod")[index - 1].style.display = 'none';
        }
        else{
            list.getElementsByClassName("mod")[buttons.length - 1].style.display = 'none';
        }
        list.getElementsByClassName("mod")[index].style.display = 'block';
    }

    //重复执行的定时器
    function play() {

        timer = setInterval(function () {
            next.onclick();
        },timerHandler)
        //timer1 = setInterval(function () {
        //    changeWidth(percentage,index, list);
        //}, 100)

    }

    ///设置初始默认宽度
    function setDefaultWidth() {

        //变量赋值
        percentage = mainInner.offsetWidth / main.offsetWidth;
        width = parseInt((main.offsetWidth * percentage) - 200 - 280-170);

        //设置core百分比
        core.style.width = width / (main.offsetWidth * percentage) * 100 + "%";
        //设置promo尺寸
        promo.style.width = width + "px";
        //设置图片尺寸
        for (var i = 0; i < 7; i++) {
            img[i].style.width = width + "px";
        }
        //设置left尺寸
        list.style.left = "-" + width + "px";

        console.log(mainInner.offsetWidth / main.offsetWidth);
    }

    //清除定时器
    function stop() {
        clearInterval(timer);
    }

    // NEXT 之后 将之前的小圆点的样式清除
    function showButtons() {
        //index 从1开始计算，故 -1 清除 第0个开始
        if (index > 0)
            buttons[index - 1].className = "";
        else
            buttons[buttons.length-1].className = "";
        //从第1个开始添加on样式
        buttons[index].className = "on";
    }

    prev.onclick = function () {
        index -= 1;
        if (index < 1) {
            index = 6
        }
        buttonsShow();
        animate(1500);
    };
    next.onclick = function () {

        //由于上边定时器的作用，index会一直递增下去，我们只有5个小圆点，所以需要做出判断
        index += 1;
        //index 从1开始传递参数
        if (index > buttons.length-1) {
            index = 0
        }
        showImg(index);
        showButtons();
    };

    for (var i = 0; i < buttons.length; i++) {
        (function (i) {
            buttons[i].onclick = function () {
                /*  这里获得鼠标移动到小圆点的位置，用this把index绑定到对象buttons[i]上，去谷歌this的用法  */
                /*  由于这里的index是自定义属性，需要用到getAttribute()这个DOM2级方法，去获取自定义index的属性*/
                var clickIndex = parseInt(this.getAttribute('index'));
                var offset = 1500 * (index - clickIndex); //这个index是当前图片停留时的index
                animate(offset);
                index = clickIndex; //存放鼠标点击后的位置，用于小圆点的正常显示
                buttonsShow();
            }
        })(i)
    }

    //鼠标事件
    promo.onmouseover = stop;
    promo.onmouseout = play;

    //下面执行顺序
    //setDefaultWidth();
    play();
    console.log(buttons.length);
    
}

function changeWidth(percentage,index, list) {
    var core = document.getElementById("core");
    var main = document.getElementById("main");
    var promo = document.getElementById("promo");
    var img = document.getElementById("promo-list").getElementsByTagName("img");
    var changeW;
    changeW = parseInt((main.offsetWidth * percentage) - 200 - 280-170);

    //设置core百分比
    core.style.width = parseInt((main.offsetWidth * percentage) - 200 - 280-170) / (main.offsetWidth * percentage) * 100 + "%";
    //设置promo尺寸
    promo.style.width = changeW + "px";
    //设置图片尺寸
    for (var i = 0; i < 7; i++) {
        img[i].style.width = parseInt(changeW) + "px";
    }
    //设置left 尺寸
    list.style.left = "-" + (changeW * index) + "px";

    //console.log("width:" + width + "---index:" + index + "---changeW:" + changeW + "---" + (width * index + (width - changeW) * index));

}



function cntopads($) {
    var rsstatus = 0;
    var bistatus = 0;
    var bro = $.browser;
    var hoverTimer, outTimer;
    $('#ctads>div').stop(false, false).hover(
        function () {
            clearTimeout(outTimer);
            hoverTimer = setTimeout(function () { mousee(); }, 300);
        },
        function () {
            clearTimeout(hoverTimer);
            outTimer = setTimeout(function () { unexpand(); }, 200);
        }
    );

    $('#closeBigimg').click(function () {
        clearTimeout(hoverTimer);
        outTimer = setTimeout(function () { unexpand(); }, 200);
    });
    function mousee() {
        if (bistatus == 0) loadBigImage();
        if (bro.msie && bro.version == '8.0') {
            $('#ctacover').css({ 'display': 'block', 'filter': 'alpha(opacity=100)' });
            $('#ctabigImg').css({ 'display': 'block', 'filter': 'alpha(opacity=100)' });
            $('#ctacover').css({ 'margin-top': '0px', 'background': '#000', 'display': 'none', 'filter': 'alpha(opacity=0)' });
        } else {
            $('#ctacover').css({ 'display': 'block', 'opacity': '0' });
            $('#ctabigImg').animate({ 'opacity': 1 }, 500);
            $('#ctacover').animate({ 'margin-top': '0px', 'background': '#000', 'opacity': '1' }, 500, function () {
                $('#ctacover').css({ 'display': 'none' });
            });
        }
        $('#ctabigImg').css({ 'display': 'block' });
        $('#ctasImg').css({ 'background-image': "url('#')" });
    }
    function loadBigImage() {
        var img = new Image();
        img.src = 'https://images-cn.ssl-images-amazon.com/images/G/28/CN-Ad/dove20191206_820460._CB446405653_.jpg';
        img.onload = function () {
            $('#ctabigImgCon').css({ 'background': "url('https://images-cn.ssl-images-amazon.com/images/G/28/CN-Ad/dove20191206_820460._CB446405653_.jpg') no-repeat center" });
            if (bro.msie && bro.version == '8.0') {
                $('#ctabigImgCon').css({ 'filter': 'alpha(opacity=100)' });
            } else {
                $('#ctabigImgCon').css({ 'opacity': 1 });
            }
            bistatus = 1;
        }
    }
    $(window).load(function () {
        if (bistatus == 0)
            loadBigImage();
    });
    function unexpand() {
        if (bro.msie && bro.version == '8.0') {
            $('#ctacover').css({ 'display': 'block', 'filter': 'alpha(opacity=100)' });
            $('#ctacover').css({ 'margin-top': '-460px', 'filter': 'alpha(opacity=0)' });
            $('#ctabigImg').css({ 'display': 'none', 'filter': 'alpha(opacity=0)' });
        } else {
            $('#ctacover').css({ 'display': 'block', 'margin-top': '-460px', 'opacity': '0' });
            //$('#ctacover').animate({'margin-top':'-460px','opacity':'0'},500,function(){
            $('#ctabigImg').css({ 'display': 'none', 'opacity': 0 });
            //});
            //$('#ctabigImg').animate({'opacity':0});
        }
        $('#ctasImg').css({ 'background-image': "url('https://images-cn.ssl-images-amazon.com/images/G/28/CN-Ad/dove20191206_82030._CB446405653_.jpg')" });
    }
    $(window).resize(function () {
        resize();
    });
    function getScrollBarWidth() {
        var __scrollBarWidth;
        var scrollBarHelper = document.createElement("div");
        scrollBarHelper.style.cssText = "overflow:scroll;width:100px;height:100px;";
        document.body.appendChild(scrollBarHelper);
        if (scrollBarHelper) {
            __scrollBarWidth = {
                horizontal: scrollBarHelper.offsetHeight - scrollBarHelper.clientHeight,
                vertical: scrollBarHelper.offsetWidth - scrollBarHelper.clientWidth
            };
        }
        document.body.removeChild(scrollBarHelper);
        return __scrollBarWidth.vertical;
    }
    var scrollBarWidth = getScrollBarWidth();

    resize();
    function resize() {
        var screewidth = $(window).width();
        if (screewidth > 1010) {
            $('#ctabigImg').css({ 'width': '820px', 'left': (screewidth - 820) / 2 + 'px' });
            $('#ctasImg').css({ 'width': screewidth - 320 + 'px', 'left': '168px' });
            $('#ctabigImgCon').css({ 'width': '820px' });
        } else {
            $('#ctabigImg').css({ 'width': '680px', 'left': '160px' });
            $('#ctasImg').css({ 'width': '680px', 'left': '160px' });
            $('#ctabigImgCon').css({ 'width': '680px' });
        }
    }
    $('body').css({ 'overflow-x': 'hidden' });

}
if (typeof P !== 'undefined') {
    P.when('A').execute(function (A) {
        var $ = A.$;
        cntopads($);
    });
} else if (typeof amznJQ !== 'undefined') {
    amznJQ.available('jQuery', function () {
        var $ = jQuery;
        cntopads($);
    });
}