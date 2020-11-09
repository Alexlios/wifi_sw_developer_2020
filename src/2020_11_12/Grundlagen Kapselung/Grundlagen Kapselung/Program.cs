using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_Kapselung
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Kombi",170,"Ein kleiner Kombi");

            auto.DisplayInfos();
            auto.SpeedUp(-5);
            auto.SpeedUp(500);
            auto.SpeedUp(150.5);
            auto.DisplayInfos();

            auto.Type = "Limousine";
            auto.CurrentSpeed = 53.7;

        }
    }
}
