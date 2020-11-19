using System;

namespace VererbungGrundlagen_2
{
    class Employee
    {
        #region PrivateFields

        private string _vorname;
        private string _nachname;
        private Guid _id;
        private DateTime _geburtsDatum;
        private decimal _gehalt;

        #endregion

        #region Properties

        public string Name
        {
            get => $"{_vorname} {_nachname}";
            set => _nachname = value;
        }

        public Guid Id
        {
            get => _id;
        }

        public DateTime GeburtsDatum
        {
            get => _geburtsDatum.Date;
        }

        public decimal Gehalt
        {
            get => _gehalt;
            set
            {
                if (!(value < 0))
                {
                    _gehalt = value;
                }
            }
        }

        #endregion

        #region Constructors

        public Employee()
        {
            _vorname = "Max";
            _nachname = "Mustermann";
            _id = Guid.NewGuid();
            _geburtsDatum = DateTime.MinValue;
            _gehalt = 0;
        }

        public Employee(string vorname, string nachname, DateTime geburtsDatum, decimal gehalt)
        {
            _vorname = vorname;
            _nachname = nachname;
            _id = Guid.NewGuid();
            _geburtsDatum = geburtsDatum.Date;
            _gehalt = gehalt;
        }

        #endregion

        #region PublicMethods

        /// <summary>
        /// Returns all information of an Employee in a System.String
        /// </summary>
        /// <returns>The info System.String</returns>
        public virtual string GetInfoString()
        {
            return $"Der Arbeiter {_vorname} {_nachname}({_id}) ist {(DateTime.Now.Date - _geburtsDatum.Date).Days / 365 - 1} Jahre alt und hat ein Gehalt von {GetCalculatedSalary()} EUR";
        }

        /// <summary>
        /// Returns a processed salary as a System.Decimal
        /// </summary>
        /// <returns>The processed salary</returns>
        public virtual decimal GetCalculatedSalary()
        {
            return _gehalt;
        }

        #endregion

    }
}