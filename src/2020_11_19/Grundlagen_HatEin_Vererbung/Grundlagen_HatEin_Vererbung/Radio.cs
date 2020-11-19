using System;
using WIFI.ToolLibrary;

namespace Grundlagen_HatEin_Vererbung
{
    class Radio
    {
        #region PrivateFields

        private double _frequency;
        private int _volume;
        private Power _powerState;

        #endregion

        #region Properties

        public double Frequency
        {
            get
            {
                return _frequency;
            }
            set
            {
                if (value > 86 && value < 102)
                {
                    _frequency = value;
                }
            }
        }

        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    _volume = value;
                }
            }
        }

        public Power PowerState
        {
            get
            {
                return _powerState;
            }
        }

        #endregion

        #region Constructors

        public Radio()
        {
            _frequency = 86;
            _volume = 10;
            _powerState = Power.Off;
        }

        public Radio(double frequency, int volume, Power powerState)
        {
            Frequency = frequency;
            Volume = volume;
            _powerState = powerState;
        }

        #endregion

        #region PublicMethods

        public string GetInfoString()
        {
            return $"{_frequency} | {_volume} | {_powerState}";
        }

        public void SetPowerState(Power newPowerState)
        {
            switch (newPowerState)
            {
                case Power.On:
                    Console.WriteLine("AN");
                    break;

                case Power.Off:
                    Console.WriteLine("AUS");
                    break;

                case Power.Suspend:
                    Console.WriteLine("Standby");
                    break;
            }
            _powerState = newPowerState;
        }

        public void MakeNoise()
        {
            if(_powerState == Power.On)
            {
                RandomAdv randomAdv = new RandomAdv();

                for (int i = 20; i > 0; i--)
                {
                    Console.WriteLine($"Broadcast ({_frequency}): {randomAdv.NextString(randomAdv.Next(5, 20))}");
                }
            }
        }

        #endregion
    }
}