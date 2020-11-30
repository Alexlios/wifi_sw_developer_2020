using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIFI.ToolLibrary.ConsoleIO
{
    public delegate void DisplayErrorHandler(string errorMessage);

    public class DisplayErrorMethods
    {
        /// <summary>
        /// Prints the error message in a Console.WriteLine()
        /// </summary>
        /// <param name="errorMessage">The message to be displayed</param>
        public static void DisplayErrorStandard(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }

        //Many more


    }
}
