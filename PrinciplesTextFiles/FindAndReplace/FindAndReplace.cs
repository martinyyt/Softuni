using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FindAndReplace
{
    class FindAndReplace
    {
        static string ReplaceSubString(string line, string oldWord, string newWord)
        {
            var newLine=Regex.Replace(line, oldWord, newWord, RegexOptions.IgnoreCase);
            //var newLine = line.Replace(oldWord, newWord);
            return newLine;

        }
        static void Main(string[] args)
        {
            string inputPath = @"..\..\TextDoc1.txt";
            string outputPath = @"..\..\TextDoc2.txt";
            string wordOld = "start";
            string wordNew = "finish";
            try
            {
                StreamReader reader = new StreamReader(inputPath, Encoding.Default);
                StreamWriter writer = new StreamWriter(outputPath, false, Encoding.UTF8);
                
                using (writer)
                {
                    using (reader)
                    {
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            line=ReplaceSubString(line, wordOld, wordNew);
                            writer.WriteLine(line);
                            line = reader.ReadLine();
                        }
                    } 
                }
                Console.WriteLine("file created");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FNF!!!!");
            }


        }
    }
}
