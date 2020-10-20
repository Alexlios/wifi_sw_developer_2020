using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abfragen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int zahl1 = 0;
            int zahl2 = 0;

            while (true)
            {
                zahl1 = rand.Next(int.MinValue, int.MaxValue);
                zahl2 = rand.Next(int.MinValue, int.MaxValue);

                if (zahl1 < zahl2 && DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                {
                    Console.Write($"{zahl1} \t< \t{zahl2}");
                }
                else
                {
                    Console.Write($"{zahl1} \t>= \t{zahl2}");
                }

                Console.ReadLine();
            }
        }
    }
}
