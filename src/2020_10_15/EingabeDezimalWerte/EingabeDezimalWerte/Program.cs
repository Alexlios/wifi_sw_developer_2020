using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EingabeDezimalWerte
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration for input variables
            string input = string.Empty;
            string input2 = string.Empty;

            //declaration for calculation variables
            double a = 0;
            double b = 0;


            //create header
            const string headerText = "Flaechen Berechnung";
            Console.WriteLine($"{new string('#', Console.WindowWidth - 1)}\n" +
                $"{new string(' ',(Console.WindowWidth - headerText.Length) / 2)}{headerText}\n" +
                $"{new string('#', Console.WindowWidth - 1)}");

            //runs as long as the input is not usable
            while (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(input2))
            {
                //display input promp for length values
                Console.WriteLine("\nBitte Seitenlaengen angeben:\n");
                Console.Write("\ta: ");
                input = Console.ReadLine();
                Console.Write("\tb: ");
                input2 = Console.ReadLine();
                Console.WriteLine();


                //tries to convert input to double and calculates rectangle area. error -> display warning and redo input
                if (double.TryParse(input, out a))
                {
                    if (double.TryParse(input2, out b))
                    {
                        Console.WriteLine($"Flaeche des Rechtecks ({a} x {b}): {a * b}\n");
                    }
                    else
                    {
                        Console.WriteLine("Eingabe war leider fehlerhaft. Bitte Zahlen (mit oder ohne Komma) eingeben.\n" +
                            $"Fehlerhafte Eingabe: {input2}");
                        input2 = string.Empty;
                    }
                }
                else
                {
                    Console.WriteLine("Eingabe war leider fehlerhaft. Bitte Zahlen (mit oder ohne Komma) eingeben.\n" +
                                                $"Fehlerhafte Eingabe: {input}");
                    input = string.Empty;
                }
            }
        }
    }
}
