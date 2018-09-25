using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortWords
{
    class SortWords
    {
        static void Main(string[] args)
        {
            string text = "as dasd,afad,asdfa , afad, afa,,asdf,,,,,,";
            Console.WriteLine(SortWordsInText(text,','));
        }

        public static string SortWordsInText(string text, params char[] symbols)
        {
            string[] words = text.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            StringBuilder sortedWords = new StringBuilder();
            foreach (var word in words)
            {                
                sortedWords.Append(word.Trim() + "/");
            }
            return sortedWords.ToString();
        }
    }
}
