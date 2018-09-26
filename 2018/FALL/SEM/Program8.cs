using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program8
    {
       // public string userInput;
        
        static void Main(string[] args)
        {
            double x = FindXOfIntersection(Console.ReadLine());

            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {0.5 * x + 1}");
            Console.ReadKey();
        }

        static double FindXOfIntersection(string userInput)
        {
            string[] input = userInput.Split();
            double k = double.Parse(input[0]);
            double b = double.Parse(input[1]);
            double xA = double.Parse(input[2]);
            double yA = double.Parse(input[3]);

            // готовая выведенная формула нахождения Х
            return (xA / k + yA - b) / (k + 1 / k);
        }
    }
}
