using System;
using WIFI.ToolLibrary.ConsoleIO;

namespace Grundlagen_Kapselung
{
    public class Auto
    {
        #region Fields
        
        private string _type;
        private int _maxSpeed;
        private double _currentSpeed;
        private string _description;
        
        #endregion
        
        #region Properties

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _type = value;
                }
            }
        }
        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
        }
        public double CurrentSpeed
        {
            get
            {
                return _currentSpeed;
            }
            set
            {
                if (!(value > _maxSpeed) && !(value < 0))
                {
                    _currentSpeed = value;
                }
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        #endregion

        #region Constructors

        public Auto()
        {
            _type = "Undefined";
            _maxSpeed = 0;
            _currentSpeed = 0;
            _description = "Undefined";
        }

        public Auto(string type, int maxSpeed, string description)
        {
            _type = type;
            if (maxSpeed < 0)
            {
                ConsoleTools.DisplayMesssage("ERROR: MaxSpeed kann nicht < 0 sein!", ConsoleColor.Red);
                _maxSpeed = 0;
            }
            else
            {
                _maxSpeed = maxSpeed;
            }

            _currentSpeed = 0;

            _description = description;
        }

        #endregion

        #region Displays

        /// <summary>
        /// Displays all infos of the car
        /// </summary>
        public void DisplayInfos()
        {
            ConsoleTools.DisplayMesssage($"Type:         {_type}", ConsoleColor.Green);
            ConsoleTools.DisplayMesssage($"MaxSpeed:     {_maxSpeed} km/h", ConsoleColor.Green);
            ConsoleTools.DisplayMesssage($"CurrentSpeed: {_currentSpeed} km/h", ConsoleColor.Green);
            ConsoleTools.DisplayMesssage($"Description:  {_description}", ConsoleColor.Green);
        }

        /// <summary>
        /// Displays the Speed of the car
        /// </summary>
        public void DisplaySpeed()
        {
            ConsoleTools.DisplayMesssage($"Speed of {_type}: {_currentSpeed}/{_maxSpeed}km/h");
        }

        #endregion

        #region PublicMethods

        /// <summary>
        /// Increases the speed of the car by a given value
        /// </summary>
        /// <param name="delta">The change of speed</param>
        public void SpeedUp(double delta)
        {
            double tempSpeed = _currentSpeed;
            tempSpeed += delta;

            if (tempSpeed < 0)
            {
                ConsoleTools.DisplayMesssage($"Geschwindigkeitsaenderung nicht zulaessig. CurrentSpeed: {_currentSpeed} FalseSpeed: {tempSpeed}", ConsoleColor.Red);
            }
            else
            {
                if (tempSpeed > _maxSpeed)
                {
                    _currentSpeed = _maxSpeed;
                }
                else
                {
                    _currentSpeed = tempSpeed;
                }
            }
        }

        #endregion
    }
}
