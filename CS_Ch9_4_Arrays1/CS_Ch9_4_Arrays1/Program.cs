using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Ch9_4_Arrays1
{
    class Program
    {
        static int CountNumInArray(int[] arr, int findThisInt)
        {
            int count = 0;
            int len = arr.Length;

            for (int i = 0; i <= len-1; ++i)
            {
                if (arr[i] == findThisInt)
                {
                    count += 1;
                }
            }



            return count;
        }




        static void Main(string[] args)
        {
            int[] arrayOfNums = { 0, 1, 2, 1, 2, 3, 4, 5, 6, 5, 6, 7, 8, 9, 8, 32, 9, 1 };
            Console.Write("Enter an integer to find in the array: ");
            int findMe = Int32.Parse(Console.ReadLine());
            int count = CountNumInArray(arrayOfNums, findMe);
            Console.WriteLine("{0} was found {1} times.", findMe, count);

            Console.Write("\n\nPress RETURN/ENTER to exit program.");
            Console.ReadLine();

        }
    }
}
