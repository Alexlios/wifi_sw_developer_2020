using System;

namespace ArrayGrundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarationen
            int zahl;
            int[] zahlen;


            //dimensionierung
            zahlen = new int[5];


            //initialisierung
            zahl = -2;


            zahlen[0] = 0;
            zahlen[1] = 1;
            zahlen[2] = 2;
            zahlen[3] = 3;
            zahlen[4] = 4;


            //ausgabe des arrays
            zahl = 1;
            foreach (int z in zahlen)
            {
                Console.WriteLine($"Element {zahl++}: {z}");
            }



        }
    }
}
