using MenuItemExample.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    public class Program
    {
        static void Main(string[] args)
        {


            ApplicationParameters applicationParameters = new ApplicationParameters();

            IMenu<ApplicationParameters> myMenu = CreateMenu();

            Console.SetCursorPosition(0, 2);

            while (true)
            {
                myMenu.Display(35);
                var mySelection = myMenu.SelectItem("Bitte einen Menüpunkt auswählen: ");


                mySelection.Execute(applicationParameters);
            }


        }

        static IMenu<ApplicationParameters> CreateMenu()
        {
            var myMenu = new Menu<ApplicationParameters>();

            myMenu.Add(new MenuItem<ApplicationParameters>("Geheimer Menüpunkt", ConsoleKey.A, GeheimeAktion, true, false));
            myMenu.Add(new MenuItem<ApplicationParameters>("Daten laden", ConsoleKey.L, DatenLaden));
            myMenu.Add(new MenuItem<ApplicationParameters>("Daten speichern", ConsoleKey.S, DatenSpeichern));
            myMenu.Add(new MenuItem<ApplicationParameters>("Daten löschen", ConsoleKey.D, DatenLoeschen));
            myMenu.Add(new MenuItem<ApplicationParameters>("Daten drucken", ConsoleKey.P, DatenDrucken));
            myMenu.Add(new EmptyItem<ApplicationParameters>());
            myMenu.Add(new SeperatorItem<ApplicationParameters>('~'));
            myMenu.Add(new EmptyItem<ApplicationParameters>());
            myMenu.Add(new ColoredMenuItem<ApplicationParameters>("Ende", ConsoleKey.Escape, Ende, ConsoleColor.Red));
            myMenu.Add(new MenuItem<ApplicationParameters>("Ende2", ConsoleKey.Enter, Ende, true, false));
            myMenu.Add(new EmptyItem<ApplicationParameters>());

            return myMenu;
        }

        static void GeheimeAktion(ApplicationParameters obj)
        {
            Console.Clear();
            Console.WriteLine("AAAAHHH!!!  ...   Du hast mich erschreckt!\n");
        }

        static void DatenLaden(ApplicationParameters obj)
        {
            Console.Clear();
            Console.WriteLine("Ich lade...\n");
        }

        static void DatenDrucken(ApplicationParameters obj)
        {
            Console.Clear();
            Console.WriteLine("Ich drucke...\n");
        }

        static void DatenLoeschen(ApplicationParameters obj)
        {
            Console.Clear();
            Console.WriteLine("Ich lösche...\n");
        }

        static void DatenSpeichern(ApplicationParameters obj)
        {
            Console.Clear();
            Console.WriteLine("Ich speicher...\n");
        }

        static void Ende(ApplicationParameters obj)
        {
            Environment.Exit(0);
        }
    }
}
