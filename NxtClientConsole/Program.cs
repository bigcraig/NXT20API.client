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
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

            var uuid = await client.GetTransactionIdAsync("");
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
