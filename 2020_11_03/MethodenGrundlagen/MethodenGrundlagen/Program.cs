using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodenGrundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayHello();
            DisplayMesssage("Ich bin Rot!!!!");
            DisplayMesssage("Und ich Gelb!!", ConsoleColor.Yellow);
            DisplaySecretMesssage("Du kannst mich nicht sehen. HAHA!");

            int intInput = GetInt("Bitte eine Zahl eingeben: ");
            DisplayMesssage(CalculateWeight(intInput).ToString(), ConsoleColor.Cyan);
        }

        static void DisplayHello()
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello!");
            Console.ForegroundColor = oldColor;
        }

        static void DisplayMesssage(string message)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = oldColor;
        }

        static void DisplayMesssage(string message, ConsoleColor messageColor)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = messageColor;
            Console.WriteLine(message);
            Console.ForegroundColor = oldColor;
        }

        static void DisplaySecretMesssage(string message)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = Console.BackgroundColor;
            Console.WriteLine(message);
            Console.ForegroundColor = oldColor;
        }

        static double CalculateWeight(double nettoWeight)
        {
            double result;

            result = nettoWeight * 1.25;

            return result;
        }

        static int GetInt(string inputPrompt)
        {
            //declarations
            int result = 0;
            string input;
            bool isInputValid = false;

            //reading input as long as it is invalid
            while(!isInputValid)
            {
                //printing specified prompt and reading the input
                Console.Write(inputPrompt);
                input = Console.ReadLine();

                //validating the input
                if(!StringIsNumber(input))
                {
                    Console.WriteLine("Input was not a number!");
                    isInputValid = false;
                    continue;
                }

                //converting the input
                isInputValid = true;
                result = int.Parse(input);
            }

            return result;
        }

        static bool StringIsNumber(string input)
        {
            //declarations
            bool isNumber = true;

            //check if there even is an input
            if(input.Length <= 0 || input == null)
            {
                isNumber = false;
            }
            else
            {
                //checking for each character if it's a number
                //if one of them isn't the whole input is invalid
                foreach (char c in input)
                {
                    if (!char.IsDigit(c))
                    {
                        isNumber = false;
                        break;
                    }
                }
            }

            return isNumber;
        }
    }
}
