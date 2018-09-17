using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;



namespace SimpleMethods
{
    class Program
    {
        static Random rnd = new Random(); // Random should be here, not declared in the method!

        static void Main(string[] args)
        {
            Console.WriteLine("Choose Method\n" +
                "1-Random\n" +
                "2-Current Day Of The Week\n" +
                "3-Computer Runtime\n" +
                "4-Find Hypotenuse\n" +
                "5-Area Of Triangle\n" +
                "6-Make Cats\n" +
                "7-Sum of String By Separator\n" +
                "8-Say Random Commercial Shit");
            var numberOfMethod = Console.ReadLine();
            Console.WriteLine();

            switch (numberOfMethod)
            {
                case "1":
                    RandomNumbers();
                    break;
                case "2":
                    CurrentDayOfTheWeek();
                    break;
                case "3":
                    Runtime();
                    break;
                case "4":
                    FindHypotenuse();
                    break;
                case "5":
                    GetAreaOfTriangle();
                    break;
                case "6":
                    MakeSomeCats(10);
                    break;
                case "7":
                    SumString(' ');
                    break;
                case "8":
                    for (int i = 0; i < 1; i++)
                    {
                        RandomCommercialText();
                    } 
                    break;
                default:
                    Console.WriteLine("Wrong choice, bye!");
                    break;
            }

        }

        static void RandomCommercialText()
        {
            string[] phrases = { "The product is excellent", "This is a great product.","I use this product all the time.",
            "This is the best product"};
            string[] events = { "Now I feel better.", "I managed to change.", "It made a miracle.",
                "I can’t believe it, but I am feeling great now.", "You should try it too. I am very satisfied." };
            string[] authorFirstNames = { "Diana", "Petya", "Stela", "Elena", "Katya" };
            string[] authorSecondNames = { "Ivanova", "Petrova", "Kirova" };
            string[] cities = { "Sofia", "Plovdiv", "Varna", "Ruse", "Burgas" };
                        
            int GenetrateIndex(string[] arr)
            {
                return rnd.Next(arr.Length);
            }

            var randomPhrase = phrases[GenetrateIndex(phrases)];
            var randomEvent = events[GenetrateIndex(events)];
            var randomName = authorFirstNames[GenetrateIndex(authorFirstNames)] +" "+ authorSecondNames[GenetrateIndex(authorSecondNames)];
            var randomCity = cities[GenetrateIndex(cities)];

            Console.WriteLine("{0} {1}\n{2}, {3}",randomPhrase,randomEvent,randomName,randomCity);

        }

        static void SumString(char separator)
        {
            string numbersString = Console.ReadLine();
            string[] numbersArray;
            numbersArray = numbersString.Split(separator);
            int[] allNumbers = new int[numbersArray.Length];
            int sum = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] == string.Empty)
                {
                    allNumbers[i] = 0;                    
                }
                else
                {
                    allNumbers[i] = int.Parse(numbersArray[i]);
                    sum += allNumbers[i];
                }
                //Console.WriteLine(numbersArray[i]);
            }
            Console.WriteLine(sum);
        }

        static void MakeSomeCats(int catsCount)
        {
            Cat[] someCats = new Cat[catsCount];

            for (int i = 0; i < someCats.Length; i++)
            {
                someCats[i] = new Cat("Cat" + Sequence.NextValue(),"");
            }

            for (int i = 0; i < someCats.Length; i++)
            {
                someCats[i].SayMeow();
            }
        }

        static void GetAreaOfTriangle()
        {
            double AreaByThreeSides(double side1, double side2, double side3)
            {
               var halfPerimeter = (side1 + side2 + side3)/2;
                return Math.Sqrt((halfPerimeter) * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
            }

            double AreaByHeigth(double side1, double heigth1)
            {
                return side1 * heigth1 / 2;
            }

            double AreaByAngle(double side1, double side2, double angleDegr)
            {
                double angleRads = (angleDegr * Math.PI) / 180;
                return (side1*side2*Math.Sin(angleRads))/ 2;
            }

            Console.WriteLine("1-Three sides\n" +
                "2-Heigth\n" +
                "3-Two sides and angle");

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    double side11 = double.Parse(Console.ReadLine());
                    double side21 = double.Parse(Console.ReadLine());
                    double side31 = double.Parse(Console.ReadLine());
                    Console.WriteLine(AreaByThreeSides(side11, side21, side31));
                    break;
                case 2:
                    double side12 = double.Parse(Console.ReadLine());
                    double heigth12 = double.Parse(Console.ReadLine());
                    Console.WriteLine(AreaByHeigth(side12, heigth12));
                    break;
                case 3:
                    double side13 = double.Parse(Console.ReadLine());
                    double side23 = double.Parse(Console.ReadLine());
                    double angleRads = double.Parse(Console.ReadLine());
                    Console.WriteLine(AreaByAngle(side13, side23, angleRads));
                    break;
                default:
                    break;
            }

        }

        static void FindHypotenuse()
        {
            double cathetus1 = double.Parse(Console.ReadLine());
            double cathetus2 = double.Parse(Console.ReadLine());
            double hypothenuse = Math.Sqrt(Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2));

            Console.WriteLine("Length of hypotenuse is {0:f4}",hypothenuse);
        }

        static void Runtime()
        {
            int seconds=Environment.TickCount/1000;
            int minutes = seconds/60;
            seconds = seconds % 60;
            int hours = minutes / 60;
            minutes = minutes % 60;
            int days = hours / 24;
            hours = hours % 24;

            Console.WriteLine("{0} Days, {1} Hours, {2} Minutes, {3} Seconds", days, hours, minutes, seconds);
        }

        static void CurrentDayOfTheWeek()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Today is {0}",today.DayOfWeek);
        }

        static void RandomNumbers()
        {
            var count = int.Parse(Console.ReadLine());
            var startNumber = int.Parse(Console.ReadLine());
            var endNumber = int.Parse(Console.ReadLine());
            Random newRandom = new Random();
            int currentNumber = 0;

            for (int i = 0; i < count; i++)
            {
                currentNumber = newRandom.Next(startNumber, endNumber+1);
                Console.WriteLine(currentNumber);
            }
        }
    }
}
