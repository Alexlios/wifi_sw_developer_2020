using System;
using WIFI.ToolLibrary.ConsoleIO;

namespace WIFI.ToolLibrary.TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            RandomAdv rndAdv = new RandomAdv();

            ConsoleTools.DisplayMesssage(rndAdv.NextString(100));
        }
    }
}
