using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Ch13_reverse_string
{
    class Program
    {
        static void ReverseString(string iString)
        {
            for (int i = iString.Length - 1; i >= 0; --i)
            {
                Console.Write("{0}", iString[i]);
            }
            Console.WriteLine();
            return;
        }
        static void Main(string[] args)
        {
            string inputString = "";
            Console.WriteLine("Enter a line of text below:");
            inputString = Console.ReadLine();
            ReverseString(inputString);

            Console.Write("\n\nPress RETURN/ENTER to end program.");
            Console.ReadLine();
        }
    }
}
