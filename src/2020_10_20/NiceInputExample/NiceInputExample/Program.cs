using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceInputExample
{
    class Program
    {
        public static int AgeInput(string errorMsg)
        {
            #region declarations

            int age = -1;
            string input = string.Empty;
            int year = DateTime.Now.Year;
            bool inputIsValid = true;

            #endregion declarations

            //as long as input is invalid
            do
            {
                //trying to read input. anything wrong -> declare input as invalid
                input = Console.ReadLine();

                inputIsValid = true;
                foreach (char c in input)
                {
                    if(!char.IsDigit(c))
                    {
                        inputIsValid = false;
                        break;
                    }
                }

                if (inputIsValid)
                {
                    age = year - int.Parse(input);

                    if (age < 7 || age > 150)//age is out of range
                    {
                        inputIsValid = false;
                    }
                }

                //if input is invalid notify the user
                if (!inputIsValid)
                {
                    Console.Write(errorMsg);
                }
            }
            while (!inputIsValid);

            return age;
        }

        static void Main(string[] args)
        {
            //declarations
            int alter = 0;

            // initial output
            Console.Write("Bitte geben Sie ihr Geburtsjahr an: ");

            //input year
            alter = AgeInput("\n!Jahreszahl nicht gueltig!\n" +
                " Das Jahr darf nicht in der Zukunft sein!\n" +
                $" Sie duerfen nicht juenger als 7 sein!(Jahr <= {DateTime.Now.Year - 7})\n" +
                $" Sie duerfen nicht aelter als 150 sein!(Jahr >= {DateTime.Now.Year - 150})\n\n" +
                "Bitte geben Sie ihr Geburstjahr an: ");

            //final output
            Console.WriteLine($"Sie sind ca. {alter} Jahre jung.");
        }
    }
}
