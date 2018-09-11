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
            int hour;
            //вводим переменную hour
            hour = Convert.ToInt32(Console.ReadLine());

            //приводим к 12-часовому циферблату
            if (hour >= 12)
            {
                hour = hour - 12;
            }

            //отличаем левую или правую части циферблата
            if (hour < 6)
            {
                Console.WriteLine(30 * hour);
            }

            else
            {
                hour = 12 - hour;
                Console.WriteLine(30 * hour);
            }

            Console.ReadKey();
        }
    }
}
