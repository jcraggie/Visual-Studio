using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Ch9_03_Spell_Last_Digit
{
    class Program
    {
        static string GetNumWord(int ones)
        {
            string word;
            word = "";
            switch (ones)
            {
                case 0:
                    word = "Zero";
                    break;
                case 1:
                    word = "One";
                    break;
                case 2:
                    word = "Two";
                    break;
                case 3:
                    word = "Three";
                    break;
                case 4:
                    word = "Four";
                    break;
                case 5:
                    word = "Five";
                    break;
                case 6:
                    word = "Six";
                    break;
                case 7:
                    word = "Seven";
                    break;
                case 8:
                    word = "Eight";
                    break;
                case 9:
                    word = "Nine";
                    break;
            }
            return word;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int num = Int32.Parse(Console.ReadLine());
            int len = (int)Math.Floor(Math.Log10(num)) + 1;
            Console.WriteLine("Math.Log10 of {0} is {1}.", num, Math.Log10(num));
            
            Console.WriteLine("The length of the int you entered is: {0}.", len);
            int ones = (num % (len * 10)) % 10;
            Console.WriteLine("Ones is: {0}.", ones);
            string numWord = GetNumWord(ones);
            Console.WriteLine("The digit is: {0}.", numWord);

            Console.Write("Press ENTER/RETURN to exit program.");
            Console.ReadLine();
        }
    }
}
