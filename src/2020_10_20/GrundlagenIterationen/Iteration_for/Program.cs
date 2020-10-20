using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_for
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1, n = 1; i <= 128; i += i, n++)
            {
                Console.WriteLine($"{n}. Durchlauf: {i}");
            }
        }
    }
}
