using System;

namespace Artikel
{
    class Program
    {
        static void Main(string[] args)
        {
            Artikel artikel = new Artikel("Banana", 200m, ArtikelStatus.Available);

            Console.WriteLine(artikel.GetInfoString());

            artikel.Bezeichnung = "Apple";
            artikel.Preis = 180.25m;
            artikel.Status = ArtikelStatus.NotAvailable;

            Console.WriteLine(artikel.GetInfoString());
        }
    }
}
