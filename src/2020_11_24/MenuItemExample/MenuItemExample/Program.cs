using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem mi = new MenuItem("Item 1", 'A');
            ColoredMenuItem cmi = new ColoredMenuItem("Item 2", 'B', ConsoleColor.Green);
            EmptyItem ei = new EmptyItem();

            mi.Display(10);
            cmi.Display(10);
            ei.Display(10);

        }
    }
}
