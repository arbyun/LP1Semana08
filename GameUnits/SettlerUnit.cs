namespace GameUnits
{
    public class SettlerUnit: Unit
    {
        public override float Cost => 5.0f;

        public SettlerUnit() : this(1, 2)
        {
        }
        
        public SettlerUnit(int movement, int health) : base(movement, health)
        {
        }
        
    }
}