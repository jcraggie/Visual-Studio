using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lists1
{
    class Program
    {
        class Test1
        {
            public string Year { get; set; }
            public int count { get; set; }
            public int count2 { get; set; }
        }


        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);
            foreach (var num in evenNumbers)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();

            List<Test1> test = new List<Test1>();
            test.Add(new Test1() { Year = "2016" });
            test.Add(new Test1() { Year = "2017" });

            foreach (Test1 aTest in test)
            {
                Console.WriteLine("{0}: {1} - {2}", aTest.Year, aTest.count, aTest.count2);
            }

            string findYear = "2018";

            var found = test.Find(x => x.Year == findYear);
            
            if (found == null)
            {
                test.Add(new Test1() { Year = findYear });
                found = test.Find(x => x.Year == findYear);
            }

            found.count++;

            foreach (Test1 aTest in test)
            {
                Console.WriteLine("{0}: {1} - {2}", aTest.Year, aTest.count, aTest.count2);
            }

            Console.Write("\n\nPress RETURN/ENTER to exit program.");
            Console.ReadLine();
        }
    }
}
