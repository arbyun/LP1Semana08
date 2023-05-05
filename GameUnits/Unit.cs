using System;

namespace GameUnits
{
    public abstract class Unit
    {

        private int movement;
        public int Health { get; set; }

        public virtual void Move(int distance)
        {
            Console.WriteLine($"Unit moved {distance} tiles.");
        }

        //Unit constructor
        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }
    }
}