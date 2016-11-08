using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Ch13_05_detect_text_in_string
{
    class Program
    {
        static string SENTENCE = "We are living in a yellow submarine. We don't have anything else."+ 
            "Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        static int CountSubstring(string findThis)
        {
            int count = 0;
            int index = -1;
            string lowerSent = SENTENCE.ToLower();
            index = lowerSent.IndexOf(findThis);
            Console.WriteLine("{0}", SENTENCE);
            Console.WriteLine("\nFinding {0} in above string.", findThis);

            if (index == -1)
            {
                Console.WriteLine("Substring {0} not found in original string above.", findThis);
                
                return 0;
            }

            while (index != -1)
            {
                Console.WriteLine("{0} found at index: {1}", findThis, index);
                count += 1;
                index = lowerSent.IndexOf(findThis, index + 1);
                
            }



            return count;
        }



        static void Main(string[] args)
        {
            int finalCount = CountSubstring("in");
            Console.WriteLine("\nFinal count is: {0}.", finalCount);
            Console.Write("\n\nPress RETURN/ENTER to exit program.");
            Console.ReadLine();


        }
    }
}
