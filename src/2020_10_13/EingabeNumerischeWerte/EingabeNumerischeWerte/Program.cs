using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EingabeNumerischeWerte
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //declarations
            int geburtsJahr = 0;
            int alter = DateTime.Now.Year;

            //reading input
            Console.Write("Bitte Geburtsjahr angeben: ");
            string eingabe = Console.ReadLine();

            //trying to parse input
            bool erfolg = int.TryParse(eingabe,out geburtsJahr);

            //validating the input and responding
            if (erfolg)
            {
                //calculate age
                alter -= geburtsJahr;
                if(alter >= 0)
                {
                    Console.WriteLine("Du bist {0} Jahre jung.", alter);
                }
                else
                {
                    Console.WriteLine("Das ist aber in der Zukunft!");
                }
            }
            else
            {
                Console.WriteLine("Die Eingabe war keine Jahreszahl!");
            }

            //nice goodbye :)
            Console.WriteLine("Auf Wiedersehen!\n");
            #endregion
        }
    }
}
