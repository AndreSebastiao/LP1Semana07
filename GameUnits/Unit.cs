using System;

namespace GameUnits
{
    public class Unit
    {
        private int movement;
        public virtual Health { get; set; }
        public abstract float Cost { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }
    }
}
