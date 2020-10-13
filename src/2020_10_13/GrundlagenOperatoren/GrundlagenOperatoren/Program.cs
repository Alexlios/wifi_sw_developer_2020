using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenOperatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            //arithmetische Operatoren: + - * / %
            Console.WriteLine("\n\narithmetische Operatoren: + - * / %\n");


            double erg = 0;
            double zahl1 = 5, zahl2 = 15;

            erg = zahl1 + zahl2;//5 + 15 = 20
            Console.WriteLine("5 + 15 = " + erg);

            erg -= zahl1;//20 - 5 = 15
            Console.WriteLine("20 - 5 = " + erg);

            erg *= zahl1;//15 * 5 = 75
            Console.WriteLine("15 * 5 = " + erg);

            erg /= zahl1;//75 / 5 = 15
            Console.WriteLine("75 / 5 = " + erg);

            erg %= zahl1;//15 % 5 = 0
            Console.WriteLine("15 % 5 = " + erg);


            //logische Operatoren: & | !
            Console.WriteLine("\n\nlogische Operatoren: & | !\n");


            bool logikErgebnis = true;
            bool wert1 = true;
            bool wert2 = false;

            logikErgebnis = wert1 & wert2;//true & false = false
            Console.WriteLine("true & false = " + logikErgebnis);

            logikErgebnis = wert1 & !wert2;//true & !false(true) = true
            Console.WriteLine("true & !false = " + logikErgebnis);

            logikErgebnis = wert1 | wert2;//true | false = true
            Console.WriteLine("true | false = " + logikErgebnis);


            //Vergleichsoperatoren: < > == != <= >=
            Console.WriteLine("\n\nVergleichsoperatoren: < > == != <= >=\n");


            bool vergleichErgebnis = 5 < 2;//false
            Console.WriteLine("5 < 2 = " + vergleichErgebnis);

            vergleichErgebnis = 5 > 2;//true
            Console.WriteLine("5 > 2 = " + vergleichErgebnis);

            vergleichErgebnis = "Gandalf" == "Atilla";//false
            Console.WriteLine("Gandalf == Atilla = " + vergleichErgebnis);

            vergleichErgebnis = "Gandalf" != "Atilla";//true
            Console.WriteLine("Gandalf != Atilla = " + vergleichErgebnis);

            vergleichErgebnis = 3 <= 3;//true
            Console.WriteLine("3 <= 3 = " + vergleichErgebnis);

            vergleichErgebnis = 3 >= 3;//true
            Console.WriteLine("3 >= 3 = " + vergleichErgebnis);


            //Increment & Decrement: ++ --
            Console.WriteLine("\n\nIncrement & Decrement: ++ --\n");


            int zahl = 5;
            Console.WriteLine("Zahl  : " + zahl);     // 5
            Console.WriteLine("Zahl++: " + zahl++); // 5
            Console.WriteLine("++Zahl: " + ++zahl); // 7
            Console.WriteLine("Zahl--: " + zahl--); // 7
            Console.WriteLine("--Zahl: " + --zahl); // 5


            //
            Console.WriteLine("\n\n\n");

        }
    }
}
