using System;

namespace GameUnits
{
    public abstract class Unit
    {

        private int _movement;
        public int Health { get; set; }
        public abstract float Cost { get; }

        public virtual void Move(int distance)
        {
            Console.WriteLine($"Unit moved {distance} tiles.");
        }

        public abstract void Attack(Unit u);

        public Unit(int movement, int health)
        {
            this._movement = movement;
            Health = health;
        }
        
        public override string ToString()
        {
            return $"{this.GetType().Name}: HP={Health} COST={Cost}";
        }
    }
}