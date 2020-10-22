using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Formelsammlung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarationen für benötigte Variabeln
            string eingabe = string.Empty;


            //Aufforderung der Eingabe
            while(string.IsNullOrEmpty(eingabe))
            {
                Console.Write("Welche Art von Rechnung moechten sie durchfuehren?\n" +
               "(V) Volumen berechnen\n" +
               "(B) Beenden\n" +
               ": ");

                eingabe = Console.ReadLine();


                //Überprüfen ob Eingabe zu gross ist
                if (eingabe.Length > 1)
                {
                    Console.WriteLine("Bitte nur den Buchstaben in den angegebenen Klammern eingeben.\n");
                    eingabe = string.Empty;
                    continue;
                }

                
                switch(eingabe[0])
                {
                    //Nutzer will Volumen berechnen
                    case 'V':
                        Volumenrechner volumenrechner = new Volumenrechner();
                        volumenrechner.EingabeAuswahl();
                        eingabe = string.Empty;
                        break;


                    //Nutzer will das Programm beenden
                    case 'B':
                        Console.WriteLine("Vielen Dank und auf Wiedersehen!");
                        Console.ReadLine();
                        break;

                    //Ungültige Eingabe
                    default:
                        Console.WriteLine("Bitte nur den Buchstaben in den angegebenen Klammern eingeben.\n");
                        eingabe = string.Empty;
                        break;
                }
            }
           
        }
    }
}
