using System;

namespace VererbungGrundlagen_2
{
    class Sales : Employee
    {
        #region PrivateFields

        private double _provision;

        #endregion

        #region Properties
        public double Provision
        {
            get => _provision;
            set => _provision = value;
        }

        #endregion

        #region Constructors

        public Sales()
        {
            _provision = 0;
        }

        public Sales(string vorname, string nachname, DateTime geburtsDatum, decimal gehalt, double provision) : base(vorname, nachname, geburtsDatum, gehalt)
        {
            _provision = provision;
        }

        #endregion

        #region PublicMethods

        /// <summary>
        /// Returns a processed salary as a System.Decimal
        /// </summary>
        /// <returns>The processed salary</returns>
        public override decimal GetCalculatedSalary()
        {
            return Gehalt * (decimal)(_provision / 100 + 1);
        }

        #endregion

    }
}
