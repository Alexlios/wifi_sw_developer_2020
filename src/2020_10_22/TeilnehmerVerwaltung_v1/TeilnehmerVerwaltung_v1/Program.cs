using System;

namespace TeilnehmerVerwaltung_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarations (and first input + check if further computing is needed)
            string[] names;
            int[] yearsOfBearth;
            int size = IntInput("Bitte die Anzahl der Teilnehmer angeben: ");

            //initialisations of arrays
            names = new string[size];
            yearsOfBearth = new int[size];

            //reading input for both arrays
            for (int i = 0; i < size; ++i)
            {
                Console.Write($"\nBitte den Namen von Teilnehmer {i + 1} angeben: ");
                names[i] = Console.ReadLine();

                yearsOfBearth[i] = IntInput($"Bitte das Geburtsjahr von Teilehmer {names[i]} angeben: ", true);
            }

            //output of the arrays
            Console.WriteLine("Hier alle ihre Teilnehmer: ");
            for (int i = 0; i < size; ++i)
            {
                Console.WriteLine($" Teilnehmer {i + 1}:\n" +
                    $"\t{names[i]} geboren {yearsOfBearth[i]}");
            }
        }

        static int IntInput(string msg,bool isYear = false)
        {
            //declarations
            int result = 0;
            bool inputIsValid = false;
            string input = string.Empty;
            int age = 0;

            //reading and validating input
            while (!inputIsValid)
            {
                //reading input
                Console.Write(msg);
                input = Console.ReadLine();

                //validating input
                inputIsValid = true;
                foreach (char c in input)
                {
                    if (!Char.IsDigit(c))
                    {
                        inputIsValid = false;
                        break;
                    }
                }

                if(input.Length <= 0)
                {
                    inputIsValid = false;
                }

                //save input or print error
                if (inputIsValid)
                {
                    result = int.Parse(input);

                    //check age if wanted
                    if(isYear)
                    {
                        age = DateTime.Now.Year - result;
                        if(age < 7 || age > 150)
                        {
                            Console.WriteLine("Teilnehmer darf nicht juenger als 7 oder aelter als 150 sein!");
                            inputIsValid = false;
                        }
                    }
                    else
                    {
                        if(result <= 0)
                        {
                            Console.WriteLine("Zahl zu klein!");
                            inputIsValid = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Eingabe fehlerhaft. Bitte nur ganze Zahl angeben!");
                }
            }

            return result;
        }
    }
}
