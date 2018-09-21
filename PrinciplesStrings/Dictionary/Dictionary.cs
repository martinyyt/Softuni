using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary

{
    class Dictionary
    {
        static void Main(string[] args)
        {
            string dictString = ".NET - platform for applications from Microsoft\n" +
                "CLR - managed execution environment for .NET\n" +
                "namespace - hierarchical organization of classes\n" +
                "wtf-1";
            Console.WriteLine(dictString);

            Dictionary<string, string> dct = new Dictionary<string, string>();
            string[] dictLines = DictionaryByLines(dictString, "\n");
            MakeDictionary(dictLines, dct);
            UseDictionary(dct, "exit");
            
            

        }
        static void UseDictionary(Dictionary<string, string> dct, string exitWord)
        {
            string enteredWord = Console.ReadLine();

            while (enteredWord!=exitWord)
            {
                if (!dct.ContainsKey(enteredWord))
                {
                    Console.WriteLine("No Such Word");
                    enteredWord = Console.ReadLine();
                    continue;
                }

                Console.WriteLine(dct[enteredWord]);
                enteredWord = Console.ReadLine();
            }

            Console.WriteLine("Bye");
        }
        
        static void MakeDictionary(string[] lines, Dictionary<string, string> dct)
        {
            string key;
            string value;
            int index = -1;
            foreach (var line in lines)
            {
                index = line.IndexOf('-');

                if (index == -1)
                {
                    continue;
                }

                key = line.Substring(0, index).Trim();
                value = line.Substring(index + 1, line.Length - index-1).Trim();
                dct.Add(key, value);
            }
            
        }

        static string[] DictionaryByLines(string text, params string[] separator)
        {
            string[] dictLines = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            return dictLines;
        }
    }
}
