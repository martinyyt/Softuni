using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_15
{
    class Program
    {
        static string Encrypt(char letter)
        {
            int ascii=letter;
            int asciiCount =(ascii.ToString()).Count();
            int middleFirst =(int)(ascii/Math.Pow(10,asciiCount-1));
            int middleSecond = ascii % 10;
            string middle = middleFirst.ToString() + middleSecond.ToString();
            string begin = ((char)(ascii + middleSecond)).ToString();
            string end = ((char)(ascii - middleFirst)).ToString();
            string encryptLetter = begin + middle + end;

            return encryptLetter;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine((int)'j');
            //Console.WriteLine(  Encrypt('a'));
            //int a = 65;

            var n = int.Parse(Console.ReadLine());
            var encryptWord = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                encryptWord += Encrypt(letter);
                //Console.WriteLine(Encrypt(letter));
            }
            Console.WriteLine(encryptWord);
        }
    }
}
