using System;
using System.IO;

namespace Csharp_PKU.Week6
{
    public class Logger

    {

        public static void Test()

        {

            LogToFile("msg", true, true);

        }

        public static string LogFile = @"logger.log";

        public static void LogToFile(string str, bool bWithTime, bool bAppendLineFeed)

        {

            if (str == null) return;

            try

            {

                string fname = LogFile;

                if (fname == "" || fname == null) return;

                StreamWriter writer = new StreamWriter(fname, true, System.Text.Encoding.Default);

                if (bWithTime) writer.WriteLine("\r\n\r\n--------- " + DateTime.Now.ToString());

                if (bAppendLineFeed) writer.WriteLine(str);

                else writer.Write(str);

                writer.Close();

            }

            catch (Exception e)

            {

                Console.Write(e);

            }

        }

    }
}
