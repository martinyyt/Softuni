using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingWords
{
    class MissingWords
    {
        static List<string> ReduceString(string text, string key)
        {
            List<string> textWords = text.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> keyWords = key.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> result = new List<string>();
            foreach (var word in textWords)
            {
                if (!keyWords.Contains(word))
                {
                    result.Add(word);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string text = "I am using hackerrank to improve prgramming";
            string key = "am hackerrank to improve";
            List<string> result = ReduceString(text, key);

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}
