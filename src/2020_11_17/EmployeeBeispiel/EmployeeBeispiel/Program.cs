using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBeispiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Gustav", "Gans", new DateTime(2000, 11, 16), 50000);

            Console.WriteLine(employee.GetInfoString());
        }
    }
}
