namespace GameUnits
{
    public class SpyUnit : XPUnit
    {
        public override float Cost => 12.5f;

        public SpyUnit() : base(8, 2)
        {
        }

        public void GetSecretInfo(Unit unit)
        {
            if (unit is SpyUnit)
            {
                //XP goes up by 3
                Xp += 3;
            }
            //If it engages with military unit then XP raises by 2
            else if (unit is MilitaryUnit)
            {
                //XP goes up by 2
                Xp += 2;
            }
            //Otherwise if it's everything else(Like settler, +1 xp)
            else
            {
                //XP goes up by 1
                Xp += 1;
            }
        }

        public override void Attack(Unit u)
        {
            
        }

        public override string ToString()
        {
            return $"{base.ToString()} XP={Xp}";
        }
    }
}