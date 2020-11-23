using System;

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
            return $"Freq. {_frequency}Hz | Vol. {_volume}dB | State {_powerState}";
        }

        public void SetPowerState(Power newPowerState)
        {
            switch (newPowerState)
            {
                case Power.On:
                    Console.WriteLine("Radio: AN");
                    break;

                case Power.Off:
                    Console.WriteLine("Radio: AUS");
                    break;

                case Power.Suspend:
                    Console.WriteLine("Radio: Standby");
                    break;
            }
            _powerState = newPowerState;
        }

        public void MakeNoise()
        {
            if(_powerState == Power.On)
            {
                Console.WriteLine("[Musik]");
            }
        }

        #endregion
    }
}