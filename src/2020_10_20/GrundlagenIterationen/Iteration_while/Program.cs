using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            //kopfgesteuert
            while (input != "q")
            {
                Console.Write("[while] Bitte geben Sie etwas ein (q um abzubrechen): ");
                input = Console.ReadLine();
            }

            //fußgesteuert
            do
            {
                Console.Write("[do-while] Bitte geben Sie etwas ein (q um abzubrechen): ");
                input = Console.ReadLine();
            }
            while (input != "q");

            Console.WriteLine("Tschuessikowski");
        }
    }
}
