<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demo_Js.aspx.cs" Inherits="Jiazhe.Web.Demo.demo_Js" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <img id="img" style="height:234px" src="https://img.alicdn.com/tfs/TB1bJVwoFY7gK0jSZKzXXaikpXa-520-280.jpg" />
        </div>
        <script>
                // 通过定时循环检测获取
                var start_time = new Date().getTime();
                //图片地址后加时间戳，是为了避免缓存
                var img_url = document.getElementById("img").src +"?"+ start_time;
                // 创建对象
                var img = new Image();
                // 改变图片的src
                img.src = img_url;
                //定时执行获取宽高
                var check = function () {
                    //  只要任何一方大于0
                    // 表示服务器已经返回宽高
                    if (img.width > 0 || img.height > 0) {
                        var diff = new Date().getTime() - start_time;
                        document.body.innerHTML += 'from: check : width:' + img.width + ',height:' + img.height + ',time:' + diff + 'ms';
                        clearInterval(set);
                    }
                }
                var set = setInterval(check, 4000);
                //加载完成获取宽高
                img.onload = function () {
                    var diff = new Date().getTime() - start_time;
                    document.body.innerHTML += 'from:onload : width:' + img.width + ',height:' + img.height + ',time:' + diff + 'ms';
                }
            //document.write(img_url);
            var img1 = document.getElementById("img");

            document.write(img1.offsetWidth);
//document.write(5 + 6);
</script>
    </form>
</body>
</html>
