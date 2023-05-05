namespace GameUnits
{
    public class MilitaryUnit: Unit
    {
        public MilitaryUnit(int movement, int health) : base(movement, health)
        {
        }
        
        public int AttackPower { get; }
        public int XP { get; private set; }

        public void Attack(Unit u)
        {
            
        }
    }
}