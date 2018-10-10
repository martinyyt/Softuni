using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_3
{
    class Program
    {
        static int WeigthString (char c1, char c2, char c3, char c4, char c5)
        {
            var weightA = 5;
            var weightB = -12;
            var weightC = 47;
            var weightD = 7;
            var weightE = -32;
            var newWord = c1.ToString();
            if (newWord.IndexOf(c2)==-1)
            {
                newWord += c2.ToString();
            }
            if (newWord.IndexOf(c3) == -1)
            {
                newWord += c3.ToString();
            }
            if (newWord.IndexOf(c4) == -1)
            {
                newWord += c4.ToString();
            }
            if (newWord.IndexOf(c5) == -1)
            {
                newWord += c5.ToString();
            }
            var weight = (1+newWord.IndexOf('a')) * weightA + (1+newWord.IndexOf('b')) * weightB +
                (1+newWord.IndexOf('c')) * weightC +
                (1+newWord.IndexOf('d')) * weightD + (1+newWord.IndexOf('e')) * weightE;
            //return newWord;
            return weight;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(WeigthString('b', 'c', 'd', 'd', 'c'));

            var weightMin = int.Parse(Console.ReadLine());
            var weightMax = int.Parse(Console.ReadLine());
            var counter = 0;

            for (char c1 = 'a'; c1 <= 'e'; c1++)
            {                               
                for (char c2 = 'a'; c2 <= 'e'; c2++)
                {                                        
                    for (char c3 = 'a'; c3 <= 'e'; c3++)
                    {
                        for (char c4 = 'a'; c4 <= 'e'; c4++)
                        {
                            for (char c5 = 'a'; c5 <= 'e'; c5++)
                            {
                                var fullString = c1.ToString()+c2.ToString()+c3.ToString()+c4.ToString()+c5.ToString();
                                //Console.Write (fullString+";");
                                if (WeigthString(c1,c2,c3,c4,c5)>=weightMin&& WeigthString(c1, c2, c3, c4, c5) <= weightMax)
                                {
                                    Console.Write(fullString+" ");
                                    counter++;
                                }

                            }
                        }
                    }
                }
            }
            if (counter==0)
            {
                Console.Write("No");
            }
            Console.WriteLine();

        }
    }
}
