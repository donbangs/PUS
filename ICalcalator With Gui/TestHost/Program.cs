using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TestHost.ServiceReference2;
using TestHost.ServiceReference3;
namespace TestHost
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient client = new CalculatorClient();
            Console.WriteLine("Liczba 1 \n");
            Console.WriteLine("Real:");
            double l1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Imag:");
            double l2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Liczba 2\n");
            Console.WriteLine("Real:");
            double l3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Imag:");
            double l4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik: " + client.GetValue(client.Add(new Complex { RealValue = l1, ImagValue = l2 }, new Complex { RealValue = l3, ImagValue = l4 })) + "\n");
            Console.ReadKey();
        }
    }
}
