namespace GameUnits
{
    public class SettlerUnit: Unit
    {
        public override float Cost => 5f;
        public override void Attack(Unit u)
        {
            
        }

        public SettlerUnit() : this(2, 1)
        {
        }
        
        public SettlerUnit(int movement, int health) : base(movement, health)
        {
        }
        
    }
}