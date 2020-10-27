using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Uebungen
{
    class Uebung3
    {
        public static void Start()
        {
            bool isInputValid = false;
            string input = string.Empty;
            int betrag = 355;
            double printBetrag = 0;

            while(!isInputValid)
            {
                if(betrag == 0)
                {
                    isInputValid = true;
                    break;
                }
                else
                {
                    printBetrag = (double)betrag / 100;
                    Console.WriteLine("Noch zu zahlender Betrag: " + printBetrag + " Euro");
                }
                Console.Write("Bitte eine Euro-Muenze angeben (5,10,20,50,100,200): ");
                input = Console.ReadLine();

                switch(input)
                {
                    case "5":
                        betrag -= 5;
                        break;

                    case "10":
                        betrag -= 10;
                        break;

                    case "20":
                        betrag -= 20;
                        break;

                    case "50":
                        betrag -= 50;
                        break;

                    case "100":
                        betrag -= 100;
                        break;

                    case "200":
                        betrag -= 200;
                        break;

                    default:
                        Console.WriteLine("Eingabe nicht erkannt!");
                        break;
                }
            }
        }
    }
}
