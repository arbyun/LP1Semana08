namespace GameUnits
{
    public abstract class SpyUnit : XPUnit
    {
        public override float Cost => 12.5f;

        public SpyUnit() : base(8, 2)
        {
        }

        public void GetSecretInfo(Unit unit)
        {
            Xp += unit switch
            {
                SpyUnit _ => 3,
                MilitaryUnit _ => 2,
                _ => 1
            };
        }
    }
}