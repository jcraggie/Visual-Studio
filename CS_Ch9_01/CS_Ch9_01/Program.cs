using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Ch9_01
{
    class Program
    {
        static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
            return;
        }

        static string GetName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static void Main(string[] args)
        {
            string name = GetName();
            PrintName(name);

            Console.Write("\n\nPress ENTER/RETURN to exit.");
            Console.ReadLine();
        }
    }
}
