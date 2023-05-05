namespace GameUnits
{
    public class MilitaryUnit: Unit
    {
        public override float Cost { get { return AttackPower + Xp; } }

        private int AttackPower { get; }
        private int Xp { get; set; }

        public MilitaryUnit(int movement, int health, int attackPower) : base(movement, health)
        {
            AttackPower = attackPower;
        }

        protected override int Health
        {
            get => base.Health + Xp;
            set => base.Health = value;
        }
        
        public void Attack(Unit u)
        {
            if (u is MilitaryUnit enemy)
            {
                enemy.Health -= AttackPower;
                Xp++;
            }
        }
    }
}