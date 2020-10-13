using System;

/*
 * Projektname: Visitenkarte
 * 
 * 
 *  Vorname:    Alexander
 *  Nachname:   Schoenberger
 *  
 *  Wohnort:    Wangen im Allgaeu   PLZ: 88239
 *  Warum C#:
 *  
 *          Weil es ein aktueller Standard der flexiel ist und vielseitig anwendbar.
 *          Fuer sowohl private als auch berufliche Zwecke ;)
 * 
 */

namespace Visitenkarte
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nProjektname:\tVisitenkarte\n\n\n" +
                " Vorname:\tAlexander\n" +
                " Nachname:\tSchoenberger\n\n" +
                " Wohnort:\tWangen im Allgaeu\tPLZ: 88239\n" +
                " Warum C#:\n\n" +
                "\tWeil es ein aktueller Standard der flexiel ist und vielseitig anwendbar.\n" +
                "\tFuer sowohl private als auch berufliche Zwecke;)\n\n");


            Console.Write("Wie sieht deine Visitenkarte aus?\nWillst du deine eingeben? (Y/N):");
            string eingab = Console.ReadLine();

            if (eingab == "N") Console.WriteLine("In Ordnung. Auf Wiedersehen!");
            if (eingab == "Y")
            {
                Console.Write(" Vorname:\t");
                eingab = Console.ReadLine();
            }
        }
    }
}
