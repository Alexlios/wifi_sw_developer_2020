using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenEingaben
{
    class Program
    {
        static void Main(string[] args)
        {
            #region advanced hello world!
            Console.Write("Bitte Name eingeben: ");
            string name = Console.ReadLine();

            string output = $"Hallo {name}!";
            Console.WriteLine(output);

            output = string.Format("Ich find {0} einen super Namen!", name);
            Console.WriteLine(output);
            #endregion advanced hello world!
            
        }
    }
}
