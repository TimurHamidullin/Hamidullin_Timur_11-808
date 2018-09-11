using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //вводим переменные
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            //меняем местами значения
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a, b);

            Console.ReadKey();
        }
    }
}
