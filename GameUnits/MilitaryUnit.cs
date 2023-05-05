namespace GameUnits
{
    public class MilitaryUnit: Unit
    {
        public override float Cost { get { return AttackPower + XP; } }

        public int AttackPower { get; }
        public int XP { get; private set; }

        public MilitaryUnit(int movement, int health, int attackPower) : base(movement, health)
        {
            AttackPower = attackPower;
        }

        protected override int Health
        {
            get { return base.Health + XP; }
            set { base.Health = value; }
        }
        
        public void Attack(Unit u)
        {
            MilitaryUnit enemy = u as MilitaryUnit;
            if (enemy != null)
            {
                enemy.Health -= AttackPower;
                XP++;
            }
        }
    }
}