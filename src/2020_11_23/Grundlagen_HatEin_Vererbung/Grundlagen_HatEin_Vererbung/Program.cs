using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_HatEin_Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle("Audi A3", "Panamera S", VehicleState.Locked, 30000);

            Console.WriteLine(v.GetInfoString());

            v.State = VehicleState.Unlocked;
            v.ChangeRadioPowerState(Power.On);
            do
            {
                v.Drive();
            } 
            while (Console.ReadLine().Length < 1);

            v.Park();
        }
    }
}
