using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DifferentWordsInStrings
{
    public class DifferentWordsInString
    {
        static void Main(string[] args)
        {
            string text = "dafa afaf, dafa, dsf afaf da dafa fad; dafa, dsf.dsf";
            Console.WriteLine(PrintSortedWords(text));

        }

        public static string PrintSortedWords(string text)
        {
            string[] words = text.Split(new char[] { ' ', ',', ';', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var wordsWithCount = new SortedDictionary<string, int>();
            foreach (var word in words)
            {
                int count;
                wordsWithCount.TryGetValue(word, out count);
                wordsWithCount[word] = count + 1;
                //Console.WriteLine(word);
            }
            StringBuilder sorted = new StringBuilder();

            foreach (var word in wordsWithCount)
            {
                sorted.Append(word.Key + " - " + word.Value + "\n");
            }

            return sorted.ToString();
        }
    }
}
