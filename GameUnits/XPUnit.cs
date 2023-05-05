namespace GameUnits
{
    public abstract class XPUnit: Unit
    {
        public int Xp { get; protected set; }

        private XPUnit(int movement, int health) : base(movement, health)
        {
            Xp = 0;
        }

        
    }
}