using System;

namespace GrundlagenKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ma = new Employee();

            ma.Name = "Franz Dieter";
            ma.State = EmployeeState.SabatTime;
            ma.Birthday = new DateTime(2000, 02, 06);


            ma.DisplayInfos();

            ma.UpdateSalary(12.5);

            Console.WriteLine();

            ma = new Employee();

            ma.DisplayInfos();
        }
    }
}
