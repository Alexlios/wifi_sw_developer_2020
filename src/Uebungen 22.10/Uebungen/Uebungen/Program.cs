using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarations and initialisations
            bool isInputValid = false;
            string input = string.Empty;

            //repeat as long the input is invalid
            while (!isInputValid)
            {
                //reading the input
                Console.Write("Bitte eine Zahl von 1 - 8 (1,2,3,8) angeben um die jeweilige Uebung auszuwaehlen: ");
                input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        Uebung1.Start();
                        isInputValid = true;
                        break;

                    case "2":
                        Uebung2.Start();
                        isInputValid = true;
                        break;

                    case "3":
                        Uebung3.Start();
                        isInputValid = true;
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        break;

                    case "7":
                        break;

                    case "8":
                        Uebung8.Start();
                        isInputValid = true;
                        break;

                    //input is invalid:
                    default:
                        Console.WriteLine("Eingabe fehlerhaft! Bitte nur eine Zahl von 1 bis 8 angeben!");
                        isInputValid = false;
                        break;
                }
            }
        }
    }
}
