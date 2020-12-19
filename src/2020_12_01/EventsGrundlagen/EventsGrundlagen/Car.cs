using System;

namespace EventsGrundlagen
{
    public delegate void CarExplodedHandler(int currentSpeed, int maxSpeed);

    public class Car
    {
        private readonly string _description;
        private readonly int _maxSpeed;
        private int _speed;
        private State _state;

        public event CarExplodedHandler CarExploded;

        public State State
        {
            get { return _state; }
        }

        public int Speed
        {
            get { return _speed; }
        }


        public Car(string description, int maxSpeed)
        {
            _description = description;
            _maxSpeed = maxSpeed;
            _state = State.Normal;
            _speed = 0;
        }

        public void SpeedUp(int delta)
        {
            _speed += delta;

            if(_speed > _maxSpeed)
            {
                _state = State.Exploded;
                CarExploded?.Invoke(_speed, _maxSpeed);
            }
        }

        public override string ToString()
        {
            return $"{_description} = [{_state}] | {_speed}/{_maxSpeed} km/h";
        }
    }
}