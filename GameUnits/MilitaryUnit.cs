using System;

namespace GameUnits
{
    public class MilitaryUnit: XPUnit
    {
        public override float Cost => AttackPower + Xp;

        public int AttackPower { get; }

        public MilitaryUnit(int movement, int health, int attackPower) : base(movement, health)
        {
            AttackPower = attackPower;
        }

        public override void Attack(Unit u)
        {
            if (u is MilitaryUnit)
            {
                MilitaryUnit enemy = u as MilitaryUnit;
                int damage = Math.Min(AttackPower, enemy.Health);
                enemy.Health -= damage;
                Xp += damage;
            }
        }
        
        public override string ToString()
        {
            return $"{base.ToString()} XP={Xp} AP={AttackPower}";
        }
    }
}