using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Ch9_02
{
    class Program
    {
        static int GetMax(int x, int y)
        {
            int max = 0;
            max = x;
            if (max < y)
            {
                max = y;
            }
            return max;
        }



        static void Main(string[] args)
        {
            int a, b, c, max;
            a = b = c = 0;

            Console.Write("Enter first integer: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third integer: ");
            c = Int32.Parse(Console.ReadLine());

            max = GetMax(a, b);
            max = GetMax(max, c);
            Console.WriteLine("\nThe largest number is: {0}.", max);

            Console.Write("Press ENTER/RETURN to exit program.");
            Console.ReadLine();

        }
    }
}
