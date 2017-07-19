﻿using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Csharp_PKU.Week10
{
    class PageEncoding
    {
        //参见 http://blog.csdn.net/kybd2006/archive/2007/11/17/1889755.aspx

        public static void Test()

        {

            //string url = "http://www.baidu.com";

            string url = "http://www.pku.edu.cn";

            //if (args.Length != 0) url = args[0];

            string str = DownloadString(url);

            Console.WriteLine(str);

        }

        public static string DownloadString(string url)

        {

            string html = "";

            try

            {

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                request.Credentials = CredentialCache.DefaultCredentials;

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                Stream responseStream = response.GetResponseStream();

                //Console.Write( response.ContentType );

                //Encoding encoding = Encoding.Default;

                Encoding encoding = GuessDownloadEncoding(response); //用这个编码更好些

                if (encoding != null)

                {

                    StreamReader reader = new StreamReader(responseStream, encoding);

                    html = reader.ReadToEnd();

                    reader.Close();

                }

                else

                {

                    byte[] htmlByte = GetByteContent(responseStream);

                    html = Encoding.GetEncoding("utf-8").GetString(htmlByte);

                    string reg_charset = "(<meta[^>]*charset=(?<charset>[^>'\"]*)[\\s\\S]*?>)|(xml[^>]+encoding=(\"|')*(?<charset>[^>'\"]*)[\\s\\S]*?>)";

                    Regex r = new Regex(reg_charset, RegexOptions.IgnoreCase);

                    Match m = r.Match(html);

                    string encodingName = (m.Captures.Count != 0) ? m.Result("${charset}") : "";

                    Console.WriteLine(encodingName);

                    if (encodingName != "")

                    {

                        html = Encoding.GetEncoding(encodingName).GetString(htmlByte);

                    }

                }

                responseStream.Close();

                response.Close();

            }

            catch (UriFormatException exception)

            {

                Console.WriteLine(exception.Message.ToString());

            }

            catch (WebException exception2)

            {

                Console.WriteLine(exception2.Message.ToString());

            }

            return html;

        }

        private static byte[] GetByteContent(Stream stream)

        {

            ArrayList arBuffer = new ArrayList();

            byte[] buffer = new byte[1024];

            int offset = 1024;

            int count = stream.Read(buffer, 0, offset);

            while (count > 0)

            {

                for (int i = 0; i < count; i++)

                {

                    arBuffer.Add(buffer[i]);

                }

                count = stream.Read(buffer, 0, offset);

            }

            return (byte[])arBuffer.ToArray(typeof(byte));

        }

        private static Encoding GuessDownloadEncoding(HttpWebResponse response)

        {

            string charset = GetCharSet(response.ContentType);

            if (charset == "") charset = GetCharSet(response.Headers["Content-Type"]);

            try

            {

                if (charset != "") return Encoding.GetEncoding(charset);

            }

            catch { }

            return null;

        }

        private static string GetCharSet(string contentType)

        {

            Console.WriteLine("contentType:" + contentType);

            if (contentType == null || contentType == "") return "";

            //注:这里也可以使用正则表达式 (@"charset\b\s*=\s*(?<charset>[^""]*)")

            string[] strArray = contentType.ToLower().Split(new char[] { ';', '=', ' ' });

            bool flag = false;

            foreach (string str2 in strArray)

            {

                if (str2 == "charset")

                {

                    flag = true;

                }

                else if (flag)

                {

                    return str2;

                }

            }

            return "";

        }
    }
}
