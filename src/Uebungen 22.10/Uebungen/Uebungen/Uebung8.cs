using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    class Uebung8
    {
        //TODO: X usgabe: farblich markieren (Console.ForegroundColor = ConsoleColor.Red;)
        // X ausgabe: per Cursor Position
        // danach auch wieder hoch
        //x und y getrennt einlesen
        public static void Start()
        {
            int windHeight = Console.WindowHeight;
            int windWidth = Console.WindowWidth;

            int x = 0;
            int y = 0;

            string input = string.Empty;
            bool isInputValid = false;

            int iterations = 0;

            //ask for number of iterations
            while (!isInputValid)
            {
                isInputValid = true;
                Console.Write("Bitte die Anzahl Durchlaeufe angeben die Sie durchfuehren wollen: ");
                input = Console.ReadLine();

                if (!StringIsNumber(input))
                {
                    Console.WriteLine("Angabe war keine Zahl!");
                    isInputValid = false;
                }

            }

            Console.Clear();
            iterations = int.Parse(input);

            for (int i = 0; i < iterations; i++)
            {

                isInputValid = false;
                while (!isInputValid)
                {
                    Console.Write($"Bitte X-Koordinate angeben (X <= {windWidth}): ");
                    input = Console.ReadLine();

                    if (!StringIsNumber(input))
                    {
                        Console.Write("Angabe war keine Zahl! ");
                        continue;
                    }
                    else
                    {
                        x = int.Parse(input);

                        if (x > windWidth)
                        {
                            Console.Write("X-Koordinate zu gross! ");
                            continue;
                        }
                    }

                    Console.WriteLine($"Bitte Y-Koordinate angeben Y <= {windHeight}): ");
                    input = Console.ReadLine();

                    if (!StringIsNumber(input))
                    {
                        Console.Write("Angabe war keine Zahl! ");
                        continue;
                    }
                    else
                    {
                        y = int.Parse(input);

                        if (y > windWidth)
                        {
                            Console.Write("Y-Koordinate zu gross! ");
                            continue;
                        }
                    }

                    Console.SetCursorPosition(x, y);
                    Console.Write('X');
                    Console.SetCursorPosition(0, 0);
                }
            }

            Console.ReadKey();
        }

        static bool StringIsNumber(string input)
        {
            bool isNumber = true;

            if (input.Length <= 0)
            {
                isNumber = false;
            }
            else
            {
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
