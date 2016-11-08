using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_text_to_unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Test";

            for (int i = 0; i < text.Length; ++i)
            {
                Console.Write("\\u{0:x4}", (int)text[i]);
            }

            Console.Write("\n\nPress RETURN/ENTER to exit program.");
            Console.ReadLine();
        }
    }
}
