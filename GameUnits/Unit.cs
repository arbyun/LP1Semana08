using System;

namespace GameUnits
{
    public abstract class Unit
    {

        private int _movement;
        protected internal virtual int Health { get; set; }
        public abstract float Cost { get; }

        public virtual void Move(int distance)
        {
            Console.WriteLine($"Unit moved {distance} tiles.");
        }

        protected Unit(int movement, int health)
        {
            this._movement = movement;
            Health = health;
        }
    }
}