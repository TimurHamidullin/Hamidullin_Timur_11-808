using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int findSumOf3 = (3 + 999) * (1000 - 1) / 6;
            int findSumOf5 = (5 + 995) * (1000 - 1) / 10;
            int findSumOf15 = (15 + 985) * (1000 - 1) / 30;
            int sum = findSumOf3 + findSumOf5 - findSumOf15;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
