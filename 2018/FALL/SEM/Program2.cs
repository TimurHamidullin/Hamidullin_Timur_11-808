using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());
            int hundred = number / 100;
            int dozen = number / 10 % 10;
            int unit = number % 10;

            number = 100 * unit + 10 * dozen + hundred;

            Console.WriteLine(number);

            Console.ReadKey();
        }
    }
}
