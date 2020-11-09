using System;
using System.Globalization;

namespace WIFI.ToolLibrary.ConsoleIO
{
    /// <summary>
    /// Verschiedene Methoden zur Verwendung in Konsolen-Applikationen
    /// </summary>
    public class ConsoleTools
    {
        #region public Output

        /// <summary>
        /// Displays a given message
        /// </summary>
        /// <param name="message">The message that will be displayed</param>
        public static void DisplayMesssage(string message)
        {
            DisplayMesssage(message, Console.ForegroundColor);
        }

        /// <summary>
        /// Displays a given message with a given System.ConsoleColor
        /// </summary>
        /// <param name="message">The message that will be displayed</param>
        /// <param name="messageColor">The System.ConsoleColor that will be used</param>
        public static void DisplayMesssage(string message, ConsoleColor messageColor)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = messageColor;
            Console.WriteLine(message);
            Console.ForegroundColor = oldColor;
        }

        #endregion

        #region public Input

        /// <summary>
        /// Reads a System.Int32 value from the console
        /// </summary>
        /// <param name="inputPrompt">Prompt the user will see before the input</param>
        /// <returns>The System.Int32 that was read</returns>
        public static int GetInt(string inputPrompt)
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
        /// Reads a System.Double value from the console
        /// </summary>
        /// <param name="inputPrompt">Prompt the user will see before the input</param>
        /// <returns>The System.Double that was read</returns>
        public static double GetDouble(string inputPrompt)
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
        /// Reads a System.String from the console
        /// </summary>
        /// <param name="inputPrompt">Prompt the user will see before the input</param>
        /// <returns>The System.String that was read</returns>
        public static string GetString(string inputPrompt)
        {
            string result = string.Empty;

            //printing prompt and awaiting first input
            Console.Write(inputPrompt);
            result = Console.ReadLine();

            //if the first input was empty and while it is empty, repeating the previous step with error message
            while (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("Input was empty!");
                Console.Write(inputPrompt);
                result = Console.ReadLine();
            }
            return result;
        }

        /// <summary>
        /// Reads a System.Boolean from the console
        /// </summary>
        /// <param name="inputPrompt">Prompt the user will see before the input</param>
        /// <returns>The System.Boolean that was read</returns>
        public static bool GetBool(string inputPrompt)
        {
            //declarations
            bool result = false;
            string input;
            bool isInputValid = false;

            //reading input as long as it is invalid
            while (!isInputValid)
            {
                //printing specified prompt and reading the input
                Console.Write(inputPrompt);
                input = Console.ReadLine();

                //validating the input
                switch(input)
                {
                    case "Y":
                    case "y":
                        result = true;
                        isInputValid = true;
                        break;

                    case "N":
                    case "n":
                        result = false;
                        isInputValid = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Input. Use (Y or y) for yes and (N or n) for no");
                        isInputValid = false;
                        break;
                }
            }

            return result;
        }

        //Get File,Directory

        /// <summary>
        /// Reads a System.DateTime object value from the console. Input format: [dd.MM.yyyy HH:mm:ss]
        /// </summary>
        /// <param name="inputPrompt">Prompt the user will see before the input</param>
        /// <returns>The System.DateTime object that was read</returns>
        public static DateTime GetDateTime(string inputPrompt)
        {
            return GetDateTime(inputPrompt, "dd.MM.yyyy HH:mm:ss");
        }

        /// <summary>
        /// Reads a System.DateTime object value with a specified format from the console
        /// </summary>
        /// <param name="inputPrompt">Prompt the user will see before the input</param>
        /// <param name="inputFormat">The format in which the DateTime is read (example: [dd.MM.yyyy HH:mm:ss])</param>
        /// <returns>The System.DateTime object that was read</returns>
        public static DateTime GetDateTime(string inputPrompt, string inputFormat)
        {
            //declarations
            DateTime userInputValue = DateTime.MinValue;
            bool userInputIsValid = false;

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

        #endregion

        #region public Checkers

        /// <summary>
        /// Checks if an input is a number or not. The number has to be > 0
        /// </summary>
        /// <param name="input">the input that will be checked</param>
        /// <returns>true: input was a number   false: input was not a number</returns>
        public static bool StringIsInteger(string input)
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
        /// Checks if an input is a double or not. The number has to be > 0
        /// </summary>
        /// <param name="input">the input that will be checked</param>
        /// <returns>true: input was a double   false: input was not a double</returns>
        public static bool StringIsDouble(string input)
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

        #endregion
    }
}
