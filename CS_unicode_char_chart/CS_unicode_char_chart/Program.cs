using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_unicode_char_chart
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Char> printableChars = new List<char>();
            int ctr = 0;

            for (int i = char.MinValue; i <= char.MaxValue; i++)
            {
                char c = Convert.ToChar(i);
                if (!char.IsControl(c))
                {
                    Console.Write(" {0} = {1,-4:X}   ", c, (int)c);
                    if (ctr >= 15)
                    {
                        ctr = 0;
                        Console.WriteLine();
                    }
                    else
                    {
                        ctr++;
                    }
                    printableChars.Add(c);
                }
            }

            Console.Write("\n\nPress RETURN/ENTER to exit program.");
            Console.ReadLine();
        }
    }
}
