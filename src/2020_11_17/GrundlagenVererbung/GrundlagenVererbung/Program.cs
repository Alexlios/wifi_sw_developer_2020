using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenVererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Sales sales = new Sales("Gustav", "Gans", new DateTime(2000, 2, 6), 5000, 100);

            Console.WriteLine(sales.GetInfoString());
        }
    }
}
