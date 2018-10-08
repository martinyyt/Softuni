using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;


namespace CountWordOccurrances
{
    class WordOccurrancesInFile
    {
        static Dictionary<string, int> FileToDictionaryOfWords(string path) //no duplicates!!!
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            try
            {
                StreamReader reader = new StreamReader(path, Encoding.Default);
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        var wordArray = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var word in wordArray)
                        {
                            if (!words.ContainsKey(word))
                            {
                                words.Add(word, 0);
                            }

                        }
                        line = reader.ReadLine();
                    }
                }
                return words;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FNF!!!");
                throw;
            }

        }
        static int CountWordOccurrances(string word, string line)
        {
            int counter = 0;
            int index = line.IndexOf(word);

            while (index != -1 && index < line.Length)
            {
                counter++;
                index = line.IndexOf(word, index + 1);
            }
            return counter;
        }
        static void CountAllTheWords(Dictionary<string, int> words, string path)
        {
            var wordsList = words.Keys.ToList<string>();
            try
            {
                StreamReader reader = new StreamReader(path, Encoding.Default);
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        foreach (var word in wordsList)
                        {
                            words[word] = words[word] + CountWordOccurrances(word, line);//exception here!!!
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("FNF!!");
                throw;
            }
        }
        static void DictToFileDescending(Dictionary<string, int> words, string path)
        {
            try
            {
                StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8);
                using (writer)
                {
                    foreach (var word in words.OrderByDescending(i=>i.Value))
                    {
                        writer.WriteLine(word);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        static void Main(string[] args)
        {
            string inputWords = @"..\..\words.txt";
            string inputText = @"..\..\text.txt";
            string output = @"..\..\list.txt";
            Dictionary<string, int> words = FileToDictionaryOfWords(inputWords);
            CountAllTheWords(words, inputText);
            DictToFileDescending(words, output);
            //Dictionary<string, int> wordsCount = words.ToDictionary(;

            //foreach (var word in wordsCount)
            //{
            //    Console.WriteLine(wordsCount.Values);
            //}


            //Console.WriteLine(CountWordOccurrances("f", "fwtfwsdf wtfwtf"));           
            foreach (var word in words.OrderByDescending(i => i.Value))
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\nFile with the list was created!\n");
        }
    }
}
