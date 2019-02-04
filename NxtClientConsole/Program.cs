using MyNamespace;
using System;

namespace NxtClientConsole
{
    class Program
    {
        public static async void callMethod()
        {
            var client = new NXTClient();
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
