using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAdvanced
{
    public class TestClass
    {
        public int Divide(int z1, int z2)
        {
            if(z2 == 0)
            {
                throw new CalculationImpossibleException("z2");
            }
            Console.WriteLine("Rechne... hnnnnnnn.........ah!");
            return z1 / z2;
        }
    }
}
