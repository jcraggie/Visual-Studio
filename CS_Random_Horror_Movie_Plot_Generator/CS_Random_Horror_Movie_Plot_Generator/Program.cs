using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// family, teens, little girl, priest, scientist, single parent, writer, newlyweds
// in an old house, in the woods, in the 1800s, with a camcorder, in a space, in a hospital, lost somewhere, in Maine
// haunted by, butchered by, possessed by, chased by, tortured by, eaten by, abducted by, tormented by
// a demon, a mental patient,  aclown, zombies, some ancient evil thing, aliens, a hillbilly sadist, M. Night Shyamalan

// pick one from each line above

namespace CS_Random_Horror_Movie_Plot_Generator
{
    class Program
    {
        private static Random rnd = new Random();

        public static string GetWho()
        {
            string who = "";
            string[] whos = { "Family", "Teens", "Little girl", "Priest", "Scientist", "Single parent", "Writer", "Newlyweds" };
            int rNum = rnd.Next(whos.Length);
            who = whos[rNum];
            return who;
        }

        public static string GetWhere()
        {
            string where = "";
            string[] wheres = { "in an old house", "in the woods", "in the 1800s", "with a camcorder", "in a space", "in a hospital", "lost somewhere", "in Maine" };
            int rNum = rnd.Next(wheres.Length);
            where = wheres[rNum];
            return where;
        }

        public static string GetVerb()
        {
            string verb = "";
            string[] verbs = { "haunted by", "butchered by", "possessed by", "chased by", "tortured by", "eaten by", "abducted by", "tormented by" };
            int rNum = rnd.Next(verbs.Length);
            verb = verbs[rNum];
            return verb;
        }

        public static string GetBy()
        {
            string by = "";
            string[] bys = { "a demon", "a mental patient", "a clown", "zombies", "some ancient evil thing", "aliens", "a hillbilly sadist", "M.Night Shyamalan" };
            int rNum = rnd.Next(bys.Length);
            by = bys[rNum];
            return by;
        }


        static void Main(string[] args)
        {
            for (int i = 0; i < 20; ++i)
            {
                Console.Write("{0} ", GetWho());
                Console.Write("{0} ", GetWhere());
                Console.Write("{0} ", GetVerb());
                Console.Write("{0}.\n", GetBy());
            }

            Console.Write("\n\nPress RETURN/ENTER to end program.");
            Console.ReadLine();
        }
    }
}
