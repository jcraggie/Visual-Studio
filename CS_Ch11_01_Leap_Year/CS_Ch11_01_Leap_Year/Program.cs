using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CS_Ch11_01_Leap_Year
{
    class Program
    {
        private static Random rnd = new Random();

        static bool IsLeapYear(int year)
        {
            bool isLeapYear = DateTime.IsLeapYear(year);
            return isLeapYear;
        }

        static void Print10RandomNumbers(int start, int end)
        {
            int rNum;
            Console.WriteLine("Printing 10 random numbers between {0} and {1}.", start, end);
            for(int i = 0; i < 30; ++i)
            {
                rNum = rnd.Next(start, end + 1);
                Console.Write("{0}  ", rNum);
            }
            Console.WriteLine();
            return;
        }

        static void PrintDayOfWeekToday()
        {
            Console.WriteLine("Today is {0}.", DateTime.Today.DayOfWeek);
            return;
        }

        static void PrintSystemTime()
        {
            long tick = Environment.TickCount;
            Console.WriteLine("System has been up for {0} ticks.\n", tick);
            DateTime dtresult = new DateTime(tick);
            Console.WriteLine("DateTime from ticks is {0}.", dtresult);
            var timespan = TimeSpan.FromMilliseconds(Environment.TickCount);
            Console.WriteLine("timespan: {0}.", timespan.ToString("dd:hh:mm:ss:ff"));


        }

        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = Int32.Parse(Console.ReadLine());
            bool isLeapYear = IsLeapYear(year);
            Console.WriteLine("{0}: {1} is a leap year.", isLeapYear, year);

            Print10RandomNumbers(100, 200);

            PrintDayOfWeekToday();

            PrintSystemTime();

            Console.Write("\n\nPress RETURN/ENTER to exit program.");
            Console.ReadLine();
        }
    }
}
