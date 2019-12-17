using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.Tools.Base
{
    public class Init
    {
        public static bool IsTaobaoUrl(string str)
        {
            int a = str.IndexOf("https://m.tb.cn/");
            try
            {
                if (str.IndexOf("https://m.tb.cn/") >= 0)
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
    }
}
