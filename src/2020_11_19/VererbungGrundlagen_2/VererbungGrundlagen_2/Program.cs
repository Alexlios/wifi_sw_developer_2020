using System;

namespace VererbungGrundlagen_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sales sale = new Sales("Gustav", "Gans", new DateTime(2000, 2, 6), 100, 100);
            Console.WriteLine(sale.GetInfoString());

            Manager manager = new Manager("Gustaver", "Gansiger", new DateTime(1000, 2, 6), 50000, 20);
            Console.WriteLine(manager.GetInfoString());
        }
    }
}
