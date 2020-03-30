namespace RolePlayV23
{
    public class Damager : Character
    {
        public Damager(string name, int hitPoints, int minDamage, int maxDamage)
            : base(name, hitPoints, minDamage, maxDamage)
        {}

        #region Virtual Properties and Methods
        /// <summary>
        /// Returns the chance of the damage dealt being modified.
        /// Unless overrided in a derived class, a Character has
        /// 0 % chance of having the damage dealt modified.
        /// </summary>
        protected override int DealDamageModifyChance
        {
            get { return 40; }
        }

        /// <summary>
        /// Returns the modified dealt damage.
        /// Unless overrided in a derived class, the modified dealt 
        /// damage is the same as the original dealt damage.
        /// </summary>
        protected override int CalculateModifiedDealDamage(int dealtDamage)
        {
            return dealtDamage * 2;
        }
        #endregion
    }
}