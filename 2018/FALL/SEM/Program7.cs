using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program7
    {
        static void Main(string[] args)
        {
            double k = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());

            // параллельный и перпендикулярный векторы из начала координат с Х = 1
            Console.WriteLine("1 " + k);
            Console.WriteLine("1 " + (-1/k));

            Console.ReadKey();
        }
    }
}
