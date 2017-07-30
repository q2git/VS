using System;
using System.Net;
using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    class Program
    {

        static void Main()
        {
            GetPublicIP();
            GetPrivateIP();
            Console.WriteLine(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Console.ReadLine();
        }

        static void GetPublicIP()
        {
            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            Console.WriteLine(externalip);
            GetPrivateIP();
        }

        static void GetPrivateIP()
        {
            foreach (var interfaces in NetworkInterface.GetAllNetworkInterfaces())
            {
                foreach (var address in interfaces.GetIPProperties().UnicastAddresses)
                {
                    if (address.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork
                        && !address.Address.ToString().StartsWith("169")
                        && !address.Address.ToString().StartsWith("127"))

                        Console.WriteLine(address.Address.ToString());
                }
            }
        }
    }
}
