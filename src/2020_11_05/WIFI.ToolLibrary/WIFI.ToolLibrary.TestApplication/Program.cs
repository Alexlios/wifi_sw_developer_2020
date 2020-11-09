using System;
using WIFI.ToolLibrary.ConsoleIO;

namespace WIFI.ToolLibrary.TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleTools.DisplayMesssage("Ich werd ueber die Library ausgegeben!", ConsoleColor.Cyan);
            ConsoleTools.GetString("Brutus hau raus: ");
        }
    }
}
