using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1HW3APP
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter year");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            Console.WriteLine("{0}  is leap year",year);
            else
                Console.WriteLine("{0} is not a leap year", year);
        }
    }
}
