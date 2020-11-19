using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtikelBeispiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Artikel artikel = new Artikel();

            Console.WriteLine(artikel.GetInfoString());
        }
    }
}
