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
            // allow to change
            double hours = 12;
            double minutes = 45;

            if (hours >= 12) hours -= 12;

            double minArrowPos = minutes / 60;
            double hourArrowPos = (hours  + minArrowPos) / 12;

            double degrees = Math.Abs(hourArrowPos - minArrowPos) * 360;

            if (degrees < 180)
                Console.Write(degrees);
            else
                Console.Write(360 - degrees);

            Console.ReadKey();

        }
    }
}
