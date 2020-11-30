using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestClass();

            try
            {
                test.Divide(1, 0);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
