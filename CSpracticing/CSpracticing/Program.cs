using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CSpracticing
{
    class Program
    {
        static void Main(string[] args)
        {
            //throw new System.NotImplementedException("Intended exception.");
            System.Console.WriteLine("Hello C#!");

            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("The current directory is {0}", path);
            DateTime nowDT = DateTime.Now;
            Console.WriteLine("The current date and time is {0}.", nowDT);

            double sRoot = Math.Sqrt(12345);
            Console.WriteLine("The square root of 12345 is {0}.", sRoot);

            for (int i = -2; i > -101; --i)
            {
                if (Math.Abs(i) % 2 == 0)
                {
                    Console.Write(" {0} ", Math.Abs(i));
                }
                else
                {
                    Console.Write(" {0} ", i);
                }
            }
            Console.Write("\n");

            string sAge;
            int age;
            Console.Write("Enter your age: ");
            sAge = Console.ReadLine();
            age = int.Parse(sAge);
            age += 10;
            Console.WriteLine("Your age in 10 years will be: {0}\n", age);

            //chapter 2

            double n1 = 3.14159265d;
            double n2 = 3.14159266d;
            if (n1 > n2)
            {
                Console.WriteLine("{0} is larger than {1}.", n1, n2);
            }
            else
            {
                Console.WriteLine("{0} is smaller than {1}.", n1, n2);
            }

            int hInt = 0x256;
            Console.WriteLine("256 in hex is {0}.", hInt);

            char uniChar = '\u0048';
            Console.WriteLine("The character with hexidecimal representation of 72 (0048) is {0}.", uniChar);

            bool isMale = true;
            if (isMale)
            {
                Console.WriteLine("I am male.");
            }
            else
            {
                Console.WriteLine("I am female.");
            }

            string s1 = "Hello";
            string s2 = "World";
            object s3 = s1 + " " + s2;
            Console.WriteLine("{0} and {1} are now in object {2}.", s1, s2, s3);

            string s4 = (string)s3;
            Console.WriteLine("The object above is now typecasted to variable s4 which is {0}.", s4);

            string s5 = "The \"use\" of quotations causes difficulties.";
            string s6 = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(s5);
            Console.WriteLine(s6);

            char tri = '*';
            Console.WriteLine("\n     {0}", tri);
            for (int r = 5; r > 0; --r)
            {
                for (int s = r - 1; s > 0; --s)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(tri);
                //
            }
            for (int r = 0; r < 10; ++r)
            {
                Console.Write(tri);
            }
            Console.WriteLine("\n");

            int a = 5;
            int b = 10;
            int temp = 0;
            Console.WriteLine("a= {0} and b= {1} before the swap.", a, b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a= {0} and b= {1} after the swap.", a, b);

            //chapter 3
            int x = 6;
            int y = 4;
            Console.WriteLine(y *= 2); // 8 
            int z = y = 3; // y=3 and z=3 
            Console.WriteLine(z); // 3 
            Console.WriteLine(x |= 1); // 7 
            Console.WriteLine(x += 3); // 10 
            Console.WriteLine(x /= 2); // 5

            //chapter 4
            int e41a, e41b, e41c,e41sum;
            e41a = e41b = e41c = 0;
            Console.Write("Enter first number: ");
            e41a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            e41b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            e41c = Int32.Parse(Console.ReadLine());
            e41sum = e41a + e41b + e41c;

            Console.WriteLine("{0} + {1} + {2} = {3}", e41a, e41b, e41c,e41sum);

            //C=2 pi r   A= pi r^2
            Console.Write("\nEnter the radius of a circle: ");
            double e42r = double.Parse(Console.ReadLine());
            double e42c = 2 * Math.PI * e42r;
            double e42a = Math.PI * (e42r * e42r);
            Console.WriteLine("If Radius = {0} then Circumference = {1} and Area = {2}.", e42r, e42c, e42a);

            int hexNum = 2016;
            double fracPos = 2.656763;
            double fracNeg = -9.326757;
            Console.WriteLine("|0x{0,-8:X}|{1,-10:f2}|{2,-10:f2}|\n", hexNum, fracPos, fracNeg);

            int e45a, e45b, e45count = 0;
            Console.Write("Enter first integer: ");
            e45a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second integer (larger than the first: ");
            e45b = Int32.Parse(Console.ReadLine());
            for (int i = e45a; i <= e45b; ++i)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                    e45count += 1;
                }
            }
            Console.WriteLine("\nThere are {0} number evenly divisible by 5 between {1} and {2}.", e45count, e45a, e45b);

            int e46a = 2011;
            int e46b = 1990;
            int e46sum = e46a + e46b;
            int e46diff = e46a - e46b;
            Console.WriteLine("Numbers are: {0} and {1}.", e46a, e46b);
            Console.WriteLine("Greater: {0}", (e46sum + Math.Abs(e46diff)) / 2);
            Console.WriteLine("Smaller: {0}", (e46sum - Math.Abs(e46diff)) / 2);

            int max = e46a - ((e46a - e46b) & ((e46a - e46b) >> 31));
            Console.WriteLine("Greater using bitwise operators: {0}.",max);

            max = e46a > e46b ? e46a : e46b;
            Console.WriteLine("Greater using ternary operator ?: {0}.", max);


            //fibonacci
            long fib, prev1, prev2;
            fib = prev1 = prev2 = 0;
            for (int i = 0; i <=100; ++i)
            {
                fib = prev1 + prev2;
                Console.Write("{0}  ",fib);

                if (fib == 0)
                {
                    fib += 1;
                }
                prev2 = prev1;
                prev1 = fib;

            }

            // end program
            Console.Write("\nPress RETURN/ENTER to exit.");
            Console.ReadLine();

        }
    }
}
