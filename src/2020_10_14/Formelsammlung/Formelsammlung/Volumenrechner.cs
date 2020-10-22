using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formelsammlung
{
    //berechnet das Volumen verschiedener Körper
    class Volumenrechner
    {
        public void EingabeAuswahl()
        {
            string eingabe = string.Empty;

            //Aufforderung der Eingabe
            while (string.IsNullOrEmpty(eingabe))
            {
                Console.Write("Waehlen sie den Koerper aus fuer den sie das Volumen berechnen wollen:\n" +
                    "(W) Wuerfel\n" +
                    "(Q) Quader\n" +
                    "(P) Pyramide\n" +
                    "(T) Tetraeder\n" +
                    "(Z) Kreiszylinder\n" +
                    "(G) GeraderKreiskegel\n" +
                    "(K) Kugel\n" +
                    "(A) Abbrechen\n" +
                    ": ");
                eingabe = Console.ReadLine();


                //Überprüfen ob Eingabe zu gross ist
                if (eingabe.Length > 1)
                {
                    Console.WriteLine("Bitte nur den Buchstaben in den angegebenen Klammern eingeben.\n");
                    eingabe = string.Empty;
                    continue;
                }

                /////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///                                     TODO: abfragen auf die methoden
                /////////////////////////////////////////////////////////////////////////////////////////////////////////

                switch (eingabe[0])
                {
                    case 'W':
                        
                        break;

                    case 'Q':

                        break;

                    case 'P':

                        break;
                    
                    case 'T':

                        break;
                    
                    case 'Z':

                        break;

                    case 'G':

                        break;

                    case 'K':

                        break;
                    case 'A':
                        Console.WriteLine(/*nachricht vergeben?*/);
                        break;

                    //Ungültige Eingabe
                    default:
                        Console.WriteLine("Bitte nur den Buchstaben in den angegebenen Klammern eingeben.\n");
                        eingabe = string.Empty;
                        break;
                }

                /////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///
                /////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
        }

        void EingabeKoerper(char choice)
        {


            switch (choice)
            {
                case 'W':

                    break;

                case 'Q':

                    break;

                case 'P':

                    break;

                case 'T':

                    break;

                case 'Z':

                    break;

                case 'G':

                    break;

                case 'K':

                    break;
                case 'A':
                    Console.WriteLine(/*nachricht vergeben?*/);
                    break;

                //Ungültige Eingabe
                default:
                    Console.WriteLine("Bitte nur den Buchstaben in den angegebenen Klammern eingeben.\n");
                    break;
            }
        }

        double Wuerfel(double kantenlaenge)
        {
            return Math.Pow(kantenlaenge, 3);
        }

        double Quader(double laenge, double breite, double hoehe)
        {
            return laenge * breite * hoehe;
        }

        double GeradeQuadratischePyramide(double breite, double hoehe)
        {
            return 1 / 3 * Math.Pow(breite, 2) * hoehe;
        }

        double Tetraeder(double kantenlaenge)
        {
            return (Math.Pow(kantenlaenge, 3) / 12) * Math.Sqrt(2);
        }

        double Kreiszylinder(double radius, double hoehe)
        {
            return Math.PI * Math.Pow(radius, 2) * hoehe;
        }

        double GeraderKreiskegel(double radius, double hoehe)
        {
            return Math.PI / 3 * Math.Pow(radius, 2) * hoehe;
        }

        double Kugel(double radius)
        {
            return 4 / 3 * Math.PI * Math.Pow(radius, 3);
        }
    }
}
