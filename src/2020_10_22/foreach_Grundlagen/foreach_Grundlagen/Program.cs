using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_Grundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration (and first input)
            int size = IntInput("Bitte die Anzahl der Teilnehmer angeben: ");

            //initialisations of structs
            participant[] participants = new participant[size];

            //reading checked input for participants
            for (int i = 0; i < size; ++i)
            {
                Console.Write($"\nBitte den Vornamen von Teilnehmer {i + 1} angeben: ");
                participants[i].Name = Console.ReadLine();

                Console.Write($"Bitte den Nachnamen von Teilnehmer {participants[i].Name} angeben: ");
                participants[i].FamilyName = Console.ReadLine();

                participants[i].Birthday = DateTimeInput($"Bitte den Geburtstag von {participants[i].Name}, {participants[i].FamilyName} angeben: ");
            }

            //output of the arrays
            Console.WriteLine("\nHier alle ihre Teilnehmer: ");
            foreach (participant p in participants)
            {
                Console.WriteLine($"Teilnehmer {p.Name}, {p.FamilyName} geboren {p.Birthday.ToLongDateString()}");
            }
        }

        static int IntInput(string msg)
        {
            //declarations
            int result = 0;
            bool inputIsValid = false;
            string input = string.Empty;

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

                if (input.Length <= 0)
                {
                    inputIsValid = false;
                }

                //save input or print error
                if (inputIsValid)
                {
                    result = int.Parse(input);

                    //check for invalid numbers
                    if (result <= 0)
                    {
                        Console.WriteLine("Zahl zu klein!");
                        inputIsValid = false;
                    }
                }
                else
                {
                    Console.WriteLine("Eingabe fehlerhaft. Bitte nur ganze Zahl angeben!");
                }
            }

            return result;
        }

        static DateTime DateTimeInput(string msg)
        {
            //declarations
            DateTime result = new DateTime();
            string input = string.Empty;
            bool inputIsValid = false;
            int age = 0;

            //reading input and checking if its valid
            Console.Write(msg);
            while(!inputIsValid)
            {
                input = Console.ReadLine();

                if(!DateTime.TryParse(input, out result))
                {
                    Console.WriteLine("Eingabe fehlerhaft! Bitte Datum (DD.MM.YYYY) eingeben.");
                }
                else
                {
                    age = DateTime.Now.Year - result.Year;
                    if (age < 7 || age > 150)
                    {
                        Console.WriteLine("Teilnehmer darf nicht juenger als 7 oder aelter als 150 sein");
                    }
                    else
                    {
                        inputIsValid = true;
                    }
                }

                
            }

            return result;
        }
    }
}
