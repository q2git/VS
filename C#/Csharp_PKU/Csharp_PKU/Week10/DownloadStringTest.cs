﻿using System;
using System.IO;
using System.Net;
using System.Text;

namespace Csharp_PKU.Week10
{
    class DownloadStringTest
    {

        public static void Test()

        {

            string url = "http://www.baidu.com";

            //if (args.Length != 0) url = args[0];

            string str = DownloadString(url);

            Console.WriteLine(str);

        }

        public static string DownloadString(string url)

        {

            try

            {

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                request.Credentials = CredentialCache.DefaultCredentials;

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                Stream responseStream = response.GetResponseStream();

                Encoding encoding = Encoding.UTF8; //Encoding.Default;

                StreamReader reader = new StreamReader(responseStream, encoding);

                string str = reader.ReadToEnd();

                reader.Close();

                responseStream.Close();

                response.Close();

                return str;

            }

            catch (UriFormatException exception)

            {

                Console.WriteLine(exception.Message.ToString());

                Console.WriteLine("Invalid URL format. Please use http://www.yoursite.com");

            }

            catch (WebException exception2)

            {

                Console.WriteLine(exception2.Message.ToString());

            }

            return "";

        }
    }
}
