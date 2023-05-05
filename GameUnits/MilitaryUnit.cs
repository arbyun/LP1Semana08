namespace GameUnits
{
    public class MilitaryUnit: Unit
    {
        public override float Cost { get { return AttackPower + XP; } }

        public int AttackPower { get; }
        public int XP { get; private set; }

        public void Attack(Unit u)
        {
            
        }
    }
}