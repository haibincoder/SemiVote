using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace toupiao
{
    class Tools
    {

        public static string GetRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "get";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                string result = sr.ReadToEnd();
                return result;
            }
        }

        /// <summary>
        /// HttpPostByJson
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string HttpPostByJson(string url, string param, WebHeaderCollection headers, CookieContainer cookieContainer)
        {
            string strURL = url;
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
            //添加信息头(header)
            request.Headers = headers;
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";
            string paraUrlCoded = param;
            byte[] payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            request.ContentLength = payload.Length;
            request.CookieContainer = cookieContainer;
            Stream writer = request.GetRequestStream();
            writer.Write(payload, 0, payload.Length);
            writer.Close();
            System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
            System.IO.Stream s = response.GetResponseStream();
            string StrDate = string.Empty;
            StringBuilder sb = new StringBuilder();
            StreamReader Reader = new StreamReader(s, Encoding.UTF8);
            while ((StrDate = Reader.ReadLine()) != null)
            {
                sb.Append(StrDate);
            }
            return sb.ToString();
        }

        /// <summary>
        /// PostRequest
        /// </summary>
        /// <param name="url"></param>
        /// <param name="paramList"></param>
        /// <returns></returns>
        public static string PostRequest(string url, Dictionary<object, object> paramList, CookieContainer cookieContainer)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            StringBuilder sb = new StringBuilder();
            foreach (var item in paramList)
            {
                sb.Append(item.Key + "=" + item.Value + "&");
            }
            //将参数拼为:"name=test&pwd=123" 这种字符串格式 然后将字符串转为byte数组 最后将byte数组写入请求流中
            string paramData = sb.ToString().Trim('&');
            byte[] data = System.Text.Encoding.UTF8.GetBytes(paramData);
            //设置post方式
            request.Method = "post";
            //这句不能少  不难post请求 得不到对应的响应结果
            request.ContentType = "application/x-www-form-urlencoded";
            //设置请求参数的长度
            request.ContentLength = data.Length;
            request.CookieContainer = cookieContainer;
            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);
            stream.Close();
            /**
             * *****************注意事项********************
             * 
             * 不管是get还是post请求最后得到的响应流不能直接stream 
             * 不难得不到响应结果
             * 
             * 
             * 直接使用Stream 不能获取响应的结果值
             * 
             * 要使用StreamReader才能获取响应的结果值
             * 
             * Stream stream = response.GetResponseStream();
             * 
             * byte[] data = new byte[2*1024*1024]
             * 
             * int r = stream.Read(data,0,data.Length);
             * 
             * string result = System.Text.Encoding.UTF8.GetString(data, 0, r);
             * 
             *        
             * **/
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                string result = sr.ReadToEnd();
                return result;
            }
        }

        /// <summary>
        /// 发出GET请求
        /// </summary>
        /// <param name="Url">请求URL</param>
        /// <param name="heades">信息头</param>
        /// <returns></returns>
        public static string HttpGetByHeader(string Url, WebHeaderCollection heades)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            //添加信息头(header)
            request.Headers = heades;
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            using (var response = request.GetResponse())
            {
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
                string retString = myStreamReader.ReadToEnd();
                return retString;
            }
        }
    }
}
