using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_padleft
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Now is the time ";
            text = text + text.PadLeft(40, '*');
            Console.WriteLine("Text is {0}.", text);

            Console.Write("Press RETURN/ENTER to exit program.");
            Console.ReadLine();
        }
    }
}
