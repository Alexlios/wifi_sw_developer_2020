using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu myMenu = new Menu();

            myMenu.Add(new MenuItem("Daten laden", ConsoleKey.L));
            myMenu.Add(new MenuItem("Daten speichern", ConsoleKey.S));
            myMenu.Add(new MenuItem("Daten löschen", ConsoleKey.D));
            myMenu.Add(new MenuItem("Daten drucken", ConsoleKey.P));
            myMenu.Add(new EmptyItem());
            myMenu.Add(new ColoredMenuItem("Ende", ConsoleKey.Escape, ConsoleColor.Red));

            myMenu.Display(20);
            myMenu.SelectItem("Bitte einen Menüpunkt auswählen: ");
        }
    }
}
