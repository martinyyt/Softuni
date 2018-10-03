using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortNames
{
    class SortNames
    {
        static List<string> FileToSortedList(string path)
        {
            List<string> listOfNames = new List<string>();

            try
            {
                StreamReader reader = new StreamReader(path, Encoding.Default);
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line!=null)
                    {
                        listOfNames.Add(line);
                        line = reader.ReadLine();                        
                    }
                }
                listOfNames.Sort();
                return listOfNames;

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("FNF");
                throw e;
            }
            
        }

        static void ListToFile (List<string> sortedList, string path)
        {
            StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8);
            using (writer)
            {
                foreach (var line in sortedList)
                {
                    writer.WriteLine(line);
                }
            }
        }

        static void Main(string[] args)
        {
            string pathInput = @"..\..\TextDoc1.txt";
            string pathOutput = @"..\..\TextDoc2.txt";
            List<string> sortedNames = FileToSortedList(pathInput);
            ListToFile(sortedNames, pathOutput);
            Console.WriteLine("file created");


        }
    }
}
