using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_13
{
    class Program
    {
        static void ShowSuccessMessage(string operation, string message)
        {
            var firstLine = "Successfully executed "+operation+".";
            var numbOfLetters = firstLine.Length;
            Console.WriteLine(firstLine);
            
            Console.WriteLine(new string('=',numbOfLetters));
            Console.WriteLine("{0}.",message);
        }

        static void ShowWarningMessage(string message)
        {
            var firstLine = "Warning: " + message + ".";
            var numbOfLetters = firstLine.Length;
            Console.WriteLine(firstLine);

            Console.WriteLine(new string('=', numbOfLetters));
            
        }

        static void ShowErrorMessage(string operation, string message, int errorCode)
        {
            var firstLine = "Error: Failed to execute " + operation + ".";
            var numbOfLetters = firstLine.Length;
            Console.WriteLine(firstLine);

            Console.WriteLine(new string('=', numbOfLetters));
            Console.WriteLine("Reason: {0}.", message);
            Console.WriteLine("Error code: {0}.",errorCode);
        }

        static void ReadAndProcessMessage(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var messageType = Console.ReadLine().ToLower();
                switch (messageType)
                {
                    case "success":
                        var successOperation = Console.ReadLine();
                        var successMessage = Console.ReadLine();
                        ShowSuccessMessage(successOperation, successMessage);
                        break;
                    case "warning":
                        var warningMessage = Console.ReadLine();
                        ShowWarningMessage(warningMessage);
                        break;
                    case "error":
                        var errorOperation = Console.ReadLine();
                        var errorMessage = Console.ReadLine();
                        var errorCode = int.Parse(Console.ReadLine());
                        ShowErrorMessage(errorOperation, errorMessage, errorCode);
                        break;                        
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            ReadAndProcessMessage(n);
            //ShowSuccessMessage("hui", "maamu");
        }
    }
}
