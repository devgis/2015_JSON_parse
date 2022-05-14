using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.IO.Compression;

namespace MyJSON
{
    public class HTTPHelper
    {
        #region 无用
        //public static string GetHtmlContentByUrl(string url)
        //{

        //    var htmlContent = string.Empty;

        //    try
        //    {

        //        var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

        //        httpWebRequest.Timeout = 1;

        //        var httpWebResponse =

        //        (HttpWebResponse)httpWebRequest.GetResponse();

        //        var stream = httpWebResponse.GetResponseStream();

        //        if (stream != null)
        //        {

        //            var streamReader = new StreamReader(stream,

        //            System.Text.Encoding.UTF8);

        //            htmlContent = streamReader.ReadToEnd();

        //            streamReader.Close();

        //            streamReader.Dispose();

        //            stream.Close();

        //            stream.Dispose();

        //        }
        //    }
        //    catch
        //    { }
        //    return htmlContent;
        //}
        #endregion

        /// <summary>
        /// 获取网页内容
        /// </summary>
        /// <param name="strUrl"></param>
        /// <returns></returns>
        public static string GetContentByUrl(string strUrl)
        {
            HttpWebRequest request = WebRequest.Create(strUrl) as HttpWebRequest;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream sr = response.GetResponseStream();
            //GZipStream gzip = new GZipStream(sr, CompressionMode.Decompress);
            string shtml = string.Empty;
            using (StreamReader reader = new StreamReader(sr))
            {
                shtml = reader.ReadToEnd();
            }
            return shtml;
        }
    }
}
