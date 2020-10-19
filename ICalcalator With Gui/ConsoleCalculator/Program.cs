using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.CalculatorClient client = new ServiceReference1.CalculatorClient();
      
            Console.WriteLine("1 Dodaj\n2 Odejmij\n3 Pomnóż\n4 Podziel \n5 Dodaj Asynchronicznie\n6 Koniec\n");
            int key = int.Parse(Console.ReadLine());
            while (key != 6)
            {
             
                switch (key)
                {
                    case 1:
                        Console.WriteLine("Liczba 1 \n");
                        Console.WriteLine("Real:");
                        double  l1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Imag:");
                        double l2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Liczba 2\n");
                        Console.WriteLine("Real:");
                        double l3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Imag:");
                        double l4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Wynik: "+client.Add(new ServiceReference1.Complex { RealValue = l1, ImagValue = l2 }, new ServiceReference1.Complex { RealValue = l3, ImagValue =l4 })+"\n");
                        break;
                    case 2:
                        Console.WriteLine("Liczba 1 \n");
                        Console.WriteLine("Real:");
                        l1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Imag:");
                        l2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Liczba 2\n");
                        Console.WriteLine("Real:");
                        l3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Imag:");
                        l4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Wynik: " + client.Subtraction(new ServiceReference1.Complex { RealValue = l1, ImagValue = l2 }, new ServiceReference1.Complex { RealValue = l3, ImagValue = l4 })+"\n");
                        break;
                    case 3:
                        Console.WriteLine("Liczba 1 \n");
                        Console.WriteLine("Real:");
                        l1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Imag:");
                        l2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Liczba 2\n");
                        Console.WriteLine("Real:");
                        l3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Imag:");
                        l4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Wynik: " + client.Multiply(new ServiceReference1.Complex { RealValue = l1, ImagValue = l2 }, new ServiceReference1.Complex { RealValue = l3, ImagValue = l4 })+"\n");
                        break;
                    case 4:
                        Console.WriteLine("Liczba 1 \n");
                        Console.WriteLine("Real:");
                        l1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Imag:");
                        l2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Liczba 2\n");
                        Console.WriteLine("Real:");
                        l3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Imag:");
                        l4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Wynik: "+client.Division(new ServiceReference1.Complex { RealValue = l1, ImagValue = l2 }, new ServiceReference1.Complex { RealValue = l3, ImagValue = l4 })+"\n");
                        break;
                    case 5:
                        Console.WriteLine("Liczba 1 \n");
                        Console.WriteLine("Real:");
                        l1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Imag:");
                        l2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Liczba 2\n");
                        Console.WriteLine("Real:");
                        l3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Imag:");
                        l4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Wynik: "+client.AddAsync(new ServiceReference1.Complex { RealValue = l1, ImagValue = l2 }, new ServiceReference1.Complex { RealValue = l3, ImagValue = l4 })+"\n");
                        break;
                }
                Console.WriteLine("\n1 Dodaj\n2 Odejmij\n3 Pomnóż \n4 Podziel \n5 Dodaj Asynchronicznie\n6 Koniec\n ");
                key = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
