using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artikel
{
    class Program
    {
        static void Main(string[] args)
        {
            Artikel artikel = new Artikel("Banana",200m,ArtikelStatus.Available);

            Console.WriteLine(artikel.GetInfo());
        }
    }
}
