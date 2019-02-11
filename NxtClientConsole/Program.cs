using MyNamespace;
using System;
using System.Net;

namespace NxtClientConsole
{
    class Program
    {
        public static async void callMethod()
        {
            var client = new NXTClient();
            //   ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

            //Guid uuid = await client.GetTransactionIdAsync("");
            var response = await client.GetOnDemandMacNameAsync("78:23:AE:A3:2D:29", "", "rt1", "cmV6Host", false);
            var parameters = response.Parameters;
            Console.WriteLine("uuid");
        }
        static void Main(string[] args)
        {


            callMethod();
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
