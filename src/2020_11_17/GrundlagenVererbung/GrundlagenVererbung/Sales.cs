using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenVererbung
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

        //TODO
        public override decimal GetCalculatedSalary()
        {
            return Gehalt * (decimal)(_provision / 100 + 1);
        }

        #endregion

    }
}
