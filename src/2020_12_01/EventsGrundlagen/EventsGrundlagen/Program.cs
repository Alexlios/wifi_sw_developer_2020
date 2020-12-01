using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsGrundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car("Super Car VW", 220);

            myCar.CarExploded += MyCarExploded;

            do
            {
                Console.WriteLine(myCar);
                myCar.SpeedUp(20);
                Console.ReadKey(true);
            }
            while (true);
        }

        private static void MyCarExploded(int currentSpeed, int maxSpeed)
        {
            Console.WriteLine($"\nBoom!!!!\n\n{currentSpeed}/{maxSpeed} km/h");
            Environment.Exit(0);
        }
    }
}
