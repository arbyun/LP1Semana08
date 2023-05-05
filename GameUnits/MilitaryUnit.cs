namespace GameUnits
{
    public class MilitaryUnit: XPUnit
    {
        public override float Cost => AttackPower + Xp;

        private int AttackPower { get; }

        public MilitaryUnit(int movement, int health, int attackPower) : base(movement, health)
        {
            AttackPower = attackPower;
        }

        public void Attack(Unit u)
        {
            if (u is MilitaryUnit enemy)
            {
                enemy.Health -= AttackPower;
                Xp++;
            }
        }
        
        public override string ToString()
        {
            return $"{base.ToString()} AP={AttackPower} XP={Xp}";
        }
    }
}