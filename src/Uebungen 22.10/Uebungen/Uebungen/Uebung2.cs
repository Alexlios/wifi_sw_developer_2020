using System;

namespace Uebungen
{
    class Uebung2
    {
        public static void Start()
        {
            bool isInputVaild = false;
            string input = string.Empty;

            while(!isInputVaild)
            {
                Console.Write("Bitte Zahl zwischen 1 und 5 eingeben.\nUsereingabe:\t");
                input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        Console.WriteLine("PC: \t\tDies war die Zahl eins!");
                        isInputVaild = true;
                        break;

                    case "2":
                        Console.WriteLine("PC: \t\tDies war die Zahl zwei!");
                        isInputVaild = true;
                        break;

                    case "3":
                        Console.WriteLine("PC: \t\tDies war die Zahl drei!");
                        isInputVaild = true;
                        break;

                    case "4":
                        Console.WriteLine("PC: \t\tDies war die Zahl vier!");
                        isInputVaild = true;
                        break;

                    case "5":
                        Console.WriteLine("PC: \t\tDies war die Zahl fuenf!");
                        isInputVaild = true;
                        break;

                    default:
                        Console.WriteLine("Zahl nicht erkannt");
                        isInputVaild = false;
                        break;
                }
            }

        }
    }
}
