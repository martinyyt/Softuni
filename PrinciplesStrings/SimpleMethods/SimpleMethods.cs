using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleMethods
{
    class SimpleMethods
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Backwards("asdfghjkl;")); //practice 2

            //CountSubstring("nnnnnnnnWe are living in a yellow submarine. We don't have anything else. " +
            //    "Inside the submarine is very tight. So we are drinking all the " +
            //    "day. We will move out of it in 5 days.nnnnnn", "nnnnn"); //practice 5

            //ToUpperBetweenTags("<upcase>We are living in a <upcase>yellow submarine</upcase>. We don't " +
            //    "have <upcase> anything </upcase> else.<upcase>", "<upcase>", "</upcase>"); //practice 6

            //FillStars("adsfas", 10);    //practice 7

            //StringToUnicode("Testρϗ");  //practice 8

            //CipherText("Nakov", "ab");    //practice 9

            //FindSentenceByWord("are.nnnnnnnnWe are living in a yellow submarine. We don't have anything else. " +
            //    "Inside the submarine is very tight. So we are drinking all the " +
            //    "day. We will move out of it in 5 days.nnnnnn Are","are");  //practice 10

            //ReplaceForbiddenWords("Microsoft announced its next generation C# compiler today. " +
            //    "It uses advanced parser and special optimizer for the Microsoft CLR.", "C#,CLR,,Microsoft",',');   //practice 11
            

            
        }
        static void ReplaceForbiddenWords(string text, string allTheWords, params char[] separator)
        {
            string[] forbiddenWords = allTheWords.Split(separator,StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in forbiddenWords)
            {
                text=Regex.Replace(text, word, new string('*', word.Length));
            }
            
            Console.WriteLine(text);
        }

        static void FindSentenceByWord(string text, string word)
        {
                     
            string[] sentences = text.Split('.');
            string[] trimmedSentences = new string[sentences.Length];
            
            for (int i = 0; i < sentences.Length; i++)
            {
                trimmedSentences[i]=sentences[i].Trim();
            }
            
            foreach (var sentence in trimmedSentences)
            {
                int index = sentence.IndexOf(word, StringComparison.InvariantCultureIgnoreCase);

                if (index==-1)
                {
                    continue;
                }                
                else if (index > 0 &&
                    ((sentence[index - 1] > 64 && sentence[index - 1] < 91) ||
                    (sentence[index - 1] > 96 && sentence[index - 1] < 123)))
                {
                    continue;
                }
                else if (index + word.Length < sentence.Length &&
                    ((sentence[index + word.Length] > 64 && sentence[index + word.Length] < 91) ||
                    (sentence[index + word.Length] > 96 && sentence[index + word.Length] < 123)))
                {
                    continue;
                }

                Console.WriteLine(sentence.ToString());
            }
        }

        static void CipherText(string text, string cipher)
        {
            StringBuilder cipheredText = new StringBuilder(text.Length);
            ushort cipheredChar;

            for (int i = 0; i < text.Length; i++)
            {
                cipheredChar = (ushort)(text[i] ^ cipher[i % 2]);
                cipheredText.Append(string.Format("\\u{0:x4}", cipheredChar));
            }
            Console.WriteLine(cipheredText.ToString());
        }

        static void StringToUnicode(string text)
        {
            StringBuilder unicodeRepresentation = new StringBuilder();

            foreach (var letter in text)
            {                
                unicodeRepresentation.Append(string.Format("\\u{0:x4}",(ushort)letter));
            }

            Console.WriteLine(unicodeRepresentation.ToString());
        }

        static void FillStars(string text, int positions)
        {
            StringBuilder filledText = new StringBuilder(positions);
            for (int i = 0; i < positions; i++)
            {
                if (i<text.Length)
                {
                    filledText.Append(text[i]);
                }
                else
                {
                    filledText.Append("*");
                }
            }
            Console.WriteLine(filledText.ToString());
        }

        static void ToUpperBetweenTags(string text, string openTag, string closeTag)
        {
            int indexOpenTag = text.IndexOf(openTag);
            int indexCloseTag = text.IndexOf(closeTag,indexOpenTag);
            bool upper = false;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (indexOpenTag==i)
                {
                    upper = true;
                    indexOpenTag = text.IndexOf(openTag, i + 1);
                    i += openTag.Length;
                    if (!(i<text.Length))
                    {
                        break;
                    }
                }
                if (indexCloseTag==i)
                {
                    upper = false;
                    indexCloseTag = text.IndexOf(closeTag, i + 1);
                    i += closeTag.Length;
                    if (!(i < text.Length))
                    {
                        break;
                    }
                }
                if (upper)
                {
                    result.Append(text[i].ToString().ToUpper());
                }
                else
                {
                    result.Append(text[i]);
                }
            }

            //result.Replace(openTag, "");
            //result.Replace(closeTag, "");
            Console.WriteLine(result.ToString());
        }

        static void CountSubstring(string text, string substring)
        {
            string textLower = text.ToLower();
            string subLower = substring.ToLower();
            int index = -1;
            int counter = 0;

            do
            {
                
                index = textLower.IndexOf(subLower, index+1);
                if (index != -1)
                {
                    counter++;
                }
                
            }
            while (index != -1) ;

            Console.WriteLine(counter);
        }

        static string Backwards(string text)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = 0; i <text.Length; i++)
            {
                reversed.Insert(0, text[i]);
            }
            return reversed.ToString();
        }
    }
}
