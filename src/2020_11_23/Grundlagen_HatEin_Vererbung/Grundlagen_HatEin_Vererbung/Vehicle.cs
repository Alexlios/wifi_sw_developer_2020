using System;

namespace Grundlagen_HatEin_Vererbung
{
    class Vehicle
    {
        #region PrivateFields

        private string _model;
        private string _description;
        private VehicleState _state;
        private int _maxSpeed;
        protected Radio _radio;

        #endregion

        #region Properties

        public string Model
        {
            get
            {
                return _model;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
        }

        public VehicleState State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
        }

        public int MediaVolume
        {
            get
            {
                return _radio.Volume;
            }
            set
            {
                _radio.Volume = value;
            }
        }

        #endregion

        #region Constructors

        public Vehicle()
        {
            _model = "Rad";
            _description = "Ein einzelner Reifen. Sonst nichts";
            _maxSpeed = 0;
            _state = VehicleState.Unknown;
            _radio = new Radio();
        }

        public Vehicle(string model, string description, VehicleState state, int maxSpeed)
        {
            _model = model;
            _description = description;
            _state = state;
            _maxSpeed = maxSpeed;
            _radio = new Radio();
        }

        #endregion

        #region PublicMethods

        /// <summary>
        /// Returns information about the Vehicle
        /// </summary>
        /// <returns>The informationstring</returns>
        public string GetInfoString()
        {
            return $"{_model}, {_description}, {_maxSpeed}, {_state}\n" + _radio.GetInfoString();
        }

        /// <summary>
        /// Simulates driving
        /// </summary>
        public void Drive()
        {
            if(_state == VehicleState.Unlocked || _state == VehicleState.Driving)
            {
                Console.WriteLine("VroomVr00m");
                _radio.MakeNoise();
                Random rnd = new Random();
                if(rnd.Next(0,100) > 80)
                {
                    Console.WriteLine("BOOOM!!");
                    _state = VehicleState.Exploded;
                    _radio.SetPowerState(Power.Off);
                }
            }
            else
            {
                Console.WriteLine("Vehicle not accessible");
            }
        }

        /// <summary>
        /// Stops the driving simulation
        /// </summary>
        public void Park()
        {
            if (_state == VehicleState.Unlocked || _state == VehicleState.Driving)
            {
                Console.WriteLine("Powering down");
                _radio.SetPowerState(Power.Off);
            }
        }

        /// <summary>
        /// Changes the vehicles radio power state to a specified one
        /// </summary>
        /// <param name="power">The power state that is changed to</param>
        public void ChangeRadioPowerState(Power power)
        {
            if(_state == VehicleState.Unlocked)
            {
                _radio.SetPowerState(power);
            }
        }

        #endregion
    }
}