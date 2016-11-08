using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Ch13_06_replace_tags
{
    class Program
    {
        public static string TagSentence = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        //public static string TagSentence = "We are living in a <upcase>yellow submarine</upcase>. We.";

        public static void PrintSentence(string text)
        {
            for (int i = 0; i <text.Length; ++i)
            {
                Console.Write("{0,-3}",text[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < text.Length; ++i)
            {
                Console.Write("{0,-3}", i);
            }
            Console.WriteLine();
        }



        public static string ReplaceTags()
        {
            string newString ="";
            string replStr = "";
            string strToReplace = "";
            string startTag = "<upcase>";
            string endTag = "</upcase>";
            int sIndex = -1;
            int sIndexEnd = -1;
            int eIndex = -1;
            int eIndexEnd = -1;
            sIndex = TagSentence.IndexOf(startTag);
            int continueIndex = 0;

            //if (sIndex > -1)
                //{
                //    newString = TagSentence.Substring(0, sIndex);

                //}

            while (sIndex != -1)
            { 
                eIndex = TagSentence.IndexOf(endTag, sIndex + 1);
    
                sIndexEnd = sIndex + startTag.Length;
                eIndexEnd = eIndex + endTag.Length;
                
                Console.WriteLine();
                Console.WriteLine("sIndex = {0}   sIndexEnd = {4}   eIndex = {1}  eIndexEnd = {5}    startTag Len = {2}     endTag Len = {3}  \n", 
                    sIndex, eIndex, startTag.Length, endTag.Length, sIndexEnd, eIndexEnd);

                //Console.WriteLine("String is: {0}", TagSentence);
                //Console.WriteLine("indexes are {0} and {1}", sIndex, (eIndex - endTag.Length - 1));
                strToReplace = TagSentence.Substring(sIndex, (eIndexEnd - sIndex)); // error is occuring here
                Console.WriteLine("String to replace: {0}\n", strToReplace);

                
                replStr = TagSentence.Substring(sIndex + startTag.Length, (strToReplace.Length - endTag.Length-8));
                replStr = replStr.ToUpper();
                Console.WriteLine("Replace it with: {0}", replStr);

                newString = newString + TagSentence.Substring(continueIndex,sIndex-continueIndex) + replStr;
                Console.WriteLine("New string is: {0}", newString);
                
                sIndex = TagSentence.IndexOf(startTag, sIndex + 1);
                continueIndex = eIndexEnd;
                strToReplace = "";
                replStr = "";
            }



            return newString;

        }

        static string NewReplaceTags()
        {

            //string text = Console.ReadLine();
            string text = TagSentence;

            const string OPEN_TAG = "<upcase>";
            const string CLOSE_TAG = "</upcase>";

            while (text.Contains(OPEN_TAG) && text.Contains(CLOSE_TAG))
            {
                int openIndex = text.IndexOf(OPEN_TAG);
                int closeIndex = text.IndexOf(CLOSE_TAG);
                int lenght = closeIndex - openIndex + CLOSE_TAG.Length;

                int startIndex = openIndex + OPEN_TAG.Length;
                int lenghtOfSubstring = lenght - OPEN_TAG.Length - CLOSE_TAG.Length;
                string substring = text.Substring(startIndex, lenghtOfSubstring).ToUpper();
                Console.WriteLine("openIndex = {0}", openIndex);
                Console.WriteLine("closeIndex = {0}", closeIndex);
                Console.WriteLine("lenght = {0}", lenght);
                Console.WriteLine("startIndex = {0}", startIndex);
                Console.WriteLine("lengthOfSubstring = {0}", lenghtOfSubstring);
                Console.WriteLine("substring = {0}", substring);

                text = text.Remove(openIndex, lenght);
                PrintSentence(text);
                text = text.Insert(openIndex, substring);
                PrintSentence(text);
            }

            Console.WriteLine(text);
            return text;

        }

        static void Main(string[] args)
        {
            PrintSentence(TagSentence);
            string newStr = "";
            newStr = NewReplaceTags();
            Console.WriteLine(newStr);

            Console.Write("\n\nPress RETURN/ENTER to exit program.");
            Console.ReadLine();
        }
    }
}
