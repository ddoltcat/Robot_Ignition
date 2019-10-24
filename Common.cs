using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Robot_Ignition
{
    public class Common
    {
        /// <summary>
        /// 默认构造方法
        /// </summary>
        public Common()
        { 
        }
        /// <summary>
        /// 检查IP的合法性
        /// </summary>
        /// <param name="IP"></param>
        /// <returns></returns>
        public static  bool CheckIP(string IP_Address)
        {
            return Regex.IsMatch(IP_Address, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }
    }
}
