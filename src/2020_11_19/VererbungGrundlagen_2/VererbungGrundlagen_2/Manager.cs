using System;

namespace VererbungGrundlagen_2
{
    class Manager : Employee
    {
        #region PrivateFields

        private double _shares;

        #endregion

        #region Properties

        public double Shares
        {
            get
            {
                return _shares;
            }
        }

        #endregion

        #region Constructors

        public Manager(string vorname, string nachname, DateTime geburtsDatum, decimal gehalt, double shares) : base(vorname, nachname, geburtsDatum, gehalt)
        {
            _shares = shares;
        }

        #endregion

        #region PublicMethods

        /// <summary>
        /// Removes shares by a given amount
        /// </summary>
        /// <param name="amount">The amount of shares removed in percent</param>
        public bool RemoveShares(double amount)
        {
            amount = -Math.Abs(amount);
            return ChangeShares(amount);
        }

        /// <summary>
        /// Adds shares by a given amount
        /// </summary>
        /// <param name="amount">The amount of shares added in percent</param>
        public bool AddShares(double amount)
        {
            amount = Math.Abs(amount);
            return ChangeShares(amount);
        }

        /// <summary>
        /// Returns all information about a manager in a System.String
        /// </summary>
        /// <returns>The System.String</returns>
        public override string GetInfoString()
        {
            return base.GetInfoString().Replace(" und",",") + $" und Anteile von {_shares}%";
        }

        #endregion

        #region PrivateMethods

        /// <summary>
        /// Changes the amount of _share
        /// </summary>
        /// <param name="amount">The value it's changed by</param>
        private bool ChangeShares(double amount)
        {
            double tempShares = _shares + amount;

            if (!(tempShares < 0) && !(tempShares > 90))
            {
                _shares += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

    }
}