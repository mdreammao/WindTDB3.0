using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace myWindAPI
{
    class MyApplication
    {
        /// <summary>
        /// 将制定字符串写入指定路径的文件
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <param name="context">给定字符串</param>
        public static void TxtWrite(string path,string context)
        {
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(context);
            }
        }


        /// <summary>
        /// 去掉字符串中的数字
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string RemoveNumber(string key)
        {
            return System.Text.RegularExpressions.Regex.Replace(key, @"\d", "");
        }

        /// <summary>
        /// 去掉字符串中的非数字
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string RemoveNotNumber(string key)
        {
            return System.Text.RegularExpressions.Regex.Replace(key, @"[^\d]*", "");
        }
    }
}
