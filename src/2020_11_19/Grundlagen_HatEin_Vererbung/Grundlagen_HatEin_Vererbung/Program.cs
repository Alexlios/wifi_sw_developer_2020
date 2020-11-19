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
            Vehicle v = new Vehicle("Audi A3", "Panamera S", VehicleState.Unlocked, 30000);
            

            Radio r = new Radio();
            r.SetPowerState(Power.On);
            r.MakeNoise();
        }
    }
}
