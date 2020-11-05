using System;
using System.Collections.Generic;
using System.Globalization;
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

            int intInput = GetInt("Bitte eine ganze Zahl eingeben: ");
            DisplayMesssage(CalculateWeight(intInput).ToString(), ConsoleColor.Cyan);

            DisplayMesssage("Gelesene Eingabe: " + GetDouble("Bitte eine Kommazahl eingeben: "), ConsoleColor.Green);
            DisplayMesssage("Gelesene Eingabe: " + GetString("Bitte irgendetwas eingeben: "), ConsoleColor.Green);
            DisplayMesssage("Gelesene Eingabe: " + GetDateTime("Bitte ein Datum mit Uhrzeit eingeben (dd.MM.yyyy hh:mm:ss): "), ConsoleColor.Green);
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

        /// <summary>
        /// Reads an integer value from the console
        /// </summary>
        /// <param name="inputPrompt">Prompt the user will see before the input</param>
        /// <returns>The integer that was read</returns>
        static int GetInt(string inputPrompt)
        {
            //declarations
            int result = 0;
            string input;
            bool isInputValid = false;

            //reading input as long as it is invalid
            while (!isInputValid)
            {
                //printing specified prompt and reading the input
                Console.Write(inputPrompt);
                input = Console.ReadLine();

                //validating the input
                if (!StringIsInteger(input))
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

        /// <summary>
        /// Checks if an input is a number or not. The number has to be > 0
        /// </summary>
        /// <param name="input">the input that will be checked</param>
        /// <returns>true: input was a number   false: input was not a number</returns>
        static bool StringIsInteger(string input)
        {
            //declarations
            bool isInteger = true;

            //check if there even is an input
            if (input.Length <= 0 || input == null)
            {
                isInteger = false;
            }
            else
            {
                //checking for each character if it's a number
                //if one of them isn't the whole input is invalid
                foreach (char c in input)
                {
                    if (!char.IsDigit(c))
                    {
                        isInteger = false;
                        break;
                    }
                }
            }

            return isInteger;
        }


        /// <summary>
        /// Reads a double value from the console
        /// </summary>
        /// <param name="inputPrompt">Prompt the user will see before the input</param>
        /// <returns>The double that was read</returns>
        static double GetDouble(string inputPrompt)
        {
            //declarations
            double result = 0;
            string input;
            bool isInputValid = false;

            //reading input as long as it is invalid
            while (!isInputValid)
            {
                //printing specified prompt and reading the input
                Console.Write(inputPrompt);
                input = Console.ReadLine();

                //validating the input
                if (!StringIsDouble(input))
                {
                    Console.WriteLine("Input was not a double!");
                    isInputValid = false;
                    continue;
                }

                //converting the input
                isInputValid = true;
                result = double.Parse(input);
            }

            return result;
        }

        /// <summary>
        /// Checks if an input is a double or not. The number has to be > 0
        /// </summary>
        /// <param name="input">the input that will be checked</param>
        /// <returns>true: input was a double   false: input was not a double</returns>
        static bool StringIsDouble(string input)
        {
            //declarations
            bool isDouble = true;
            bool foundDot = false;

            //check if there even is an input
            if (input.Length <= 0 || input == null)
            {
                isDouble = false;
            }
            else
            {
                //checking for each character if it's a number
                //if one of them isn't (except . or , ) the whole input is invalid
                foreach (char c in input)
                {
                    if (c == ',')
                    {
                        if (!foundDot)
                        {
                            foundDot = true;
                            continue;
                        }
                        else
                        {
                            isDouble = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!char.IsDigit(c))
                        {
                            isDouble = false;
                            break;
                        }
                    }
                }
            }

            return isDouble;
        }

        /// <summary>
        /// Reads a string value from the console
        /// </summary>
        /// <param name="inputPrompt">Prompt the user will see before the input</param>
        /// <returns>The string that was read</returns>
        static string GetString(string inputPrompt)
        {
            //printing specified prompt, reading the input and returning it
            Console.Write(inputPrompt);
            return Console.ReadLine();
        }

        /// <summary>
        /// Reads a DateTime object value from the console. Input format: [dd.MM.yyyy hh:mm:ss]
        /// </summary>
        /// <param name="inputPrompt">Prompt the user will see before the input</param>
        /// <returns>The DateTime object that was read</returns>
        static DateTime GetDateTime(string inputPrompt)
        {
            //declarations
            DateTime userInputValue = DateTime.MinValue;
            bool userInputIsValid = false;

            string inputFormat = "dd.MM.yyyy hh:mm:ss";

            do
            {
                //displaying the specified Prompt
                Console.Write(inputPrompt);
                try
                {
                    //Reading and converting the input
                    userInputValue = DateTime.ParseExact(Console.ReadLine(), inputFormat, CultureInfo.InvariantCulture);
                    userInputIsValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    userInputIsValid = false;
                }
            }
            while (!userInputIsValid);

            return userInputValue;
        }

    }
}
