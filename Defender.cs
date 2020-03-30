namespace RolePlayV23
{
    public class Defender : Character
    {
        public Defender(string name, int hitPoints, int minDamage, int maxDamage)
            : base(name, hitPoints, minDamage, maxDamage)
        {}

        #region Virtual Properties and Methods
        /// <summary>
        /// Returns the chance of the damage received being modified.
        /// Unless overrided in a derived class, a Character has
        /// 0 % chance of having the damage Received modified.
        /// </summary>
        protected override int ReceiveDamageModifyChance
        {
            get { return 45; }
        }

        /// <summary>
        /// Returns the modified received damage.
        /// Unless overrided in a derived class, the modified received 
        /// damage is the same as the original received damage.
        /// </summary>
        protected override int CalculateModifiedReceivedDamage(int receivedDamage)
        {
            return receivedDamage / 2;
        }
        #endregion
    }
}