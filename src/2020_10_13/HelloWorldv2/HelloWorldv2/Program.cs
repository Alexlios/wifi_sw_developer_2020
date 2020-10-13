using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldv2
{
    class Program
    {
        static void Main()
        {
            const int anz = 2;
            String name = "";
            String[] test = new string[anz];
            test[0] = "Hello! What's your name?";
            test[1] = "Ok. Bye ";

            for (int i = 0; i < anz; ++i)
            {
                Console.WriteLine(test[i] + name + "!");
                if (i == 0) name = Console.ReadLine();
            }
        }
    }
}
