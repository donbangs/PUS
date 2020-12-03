using System;
using System.ServiceModel;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WcfService1.Service1));
            host.Open();
            Console.WriteLine("Press Key To Terminate \n"+"Application hosted at: " +DateTime.Now);
            Console.ReadKey();
        }
    }
}
