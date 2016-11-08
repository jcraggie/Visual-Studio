using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2016FootballPicksCScon
{
    class Program
    {
        static void Main(string[] args)
        {
            string in_FilePath;
            in_FilePath = "C:\\Users\\JRogers\\Dropbox\\GitHub\\Visual-Studio\\2016FootballPicksCScon\\2016FootballPicksCScon\\TEST.txt";

            if (File.Exists(in_FilePath) == false)
            {
                Console.Out.WriteLine("File does not exist.");
                return;
            }

            FileStream a_Stream = File.Open(in_FilePath, FileMode.Open, FileAccess.Read);
            StreamReader a_Reader = new StreamReader(a_Stream, Encoding.ASCII);

            string a_Line;
            while ((a_Line = a_Reader.ReadLine()) != null)
            {
                Console.WriteLine(a_Line);
            }

            a_Reader.Close();
        }
    }
}
