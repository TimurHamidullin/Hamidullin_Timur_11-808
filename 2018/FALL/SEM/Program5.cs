using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            //если а високосный, то учитываем а
            if ((a % 400 == 0) || ((a % 4 == 0) && (a % 100 != 0)))
            {
                count = 1;
            }
            //находим кол-во високосных лет
            a = (a / 4) - (a / 100) + (a / 400);
            b = (b / 4) - (b / 100) + (b / 400);

            count = count + b - a;

            Console.WriteLine(count);

            Console.ReadKey();

        }
    }
}
