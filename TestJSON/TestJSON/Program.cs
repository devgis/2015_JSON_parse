using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyJSON;

namespace TestJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                DateTime dt1 = DateTime.Now;
                string sResult = HTTPHelper.GetContentByUrl("http://ls.betradar.com/ls/feeds/?/betradar/en/Europe:Berlin/gismo/match_bookmakerodds/6756088"); //http://ls.betradar.com/ls/feeds/?/betradar/en/Europe:Berlin/gismo/match_bookmakerodds/6756088
                DateTime dt2 = DateTime.Now;
                TimeSpan ts = dt2 - dt1;
                Console.WriteLine(string.Format("第{0}次耗时{1}毫秒",i+1,ts.TotalMilliseconds));

                dt1 = DateTime.Now;
                JSONHelper jhelper = new JSONHelper(sResult);
                dt2 = DateTime.Now;
                ts = dt2 - dt1;
                Console.WriteLine(string.Format("*****创建JSON对象耗时{0}毫秒", ts.TotalMilliseconds));
                dt1 = DateTime.Now;
                string s = jhelper.GetParamValue("_dob");
                dt2 = DateTime.Now;
                ts = dt2 - dt1;
                Console.WriteLine(string.Format("___________________________dob_{2}_第{0}次耗时{1}毫秒", i + 1, ts.TotalMilliseconds,s));

                //Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "----------------------------------------------------------------------HttpTest");
                //string sResult = HTTPHelper.GetContentByUrl("http://ls.betradar.com/ls/feeds/?/betradar/en/Europe:Berlin/gismo/match_bookmakerodds/6756088");
                ////Console.WriteLine(HTTPHelper.GetContentByUrl("http://ls.betradar.com/ls/feeds/?/betradar/en/Europe:Berlin/gismo/match_bookmakerodds/6756088"));
                //Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "----------------------------------------------------------------------JSONTest");
                //JSONHelper jhelper = new JSONHelper("{\"code\":799,\"data\":{\"backUrl\":\"\"},\"message\":\"\u767b\u9646\u6210\u529f\"}");
                //Console.WriteLine(string.Format("Value message is:{0}", jhelper.GetParamValue("message")));
                //Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "----------------------------------------------------------------------UnixTimeTest");
                //Console.WriteLine(string.Format("Unix Time:{0} is DateTime:{1}", 1420045261, Helper.ConvertIntDateTime(1420045261)));
                //Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "----------------------------------------------------------------------TestEND");
            }
            Console.ReadLine();
        }
    }
}
