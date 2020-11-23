
//!!!NOT MY CODE!!!

namespace Grundlagen_Polymorphie.Types
{
    class Car : Vehicle
    {
        //Erbt von Vehicle. Jede klasse bekommt 1 Property und 1 Methode zusätzlich
        private int _fuel;

        public Car(string model, string description, int maxSpeed) :
            base(model, description, maxSpeed)
        {
            _fuel = 10;
        }

        public int Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public override string GetInfoString()
        {
            return base.GetInfoString() + $"\nTank: {_fuel.ToString()}%";
        }


    }
}
