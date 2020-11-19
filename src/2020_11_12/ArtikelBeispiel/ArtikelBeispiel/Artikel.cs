using System;

namespace ArtikelBeispiel
{
    public class Artikel
    {
        #region Fields

        private string _bezeichnung;
        private Guid _code;
        private decimal _preis;
        private ArtikelStatus _status;

        #endregion

        #region Properties

        public string Bezeichnung
        {
            get
            {
                return _bezeichnung;
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    _bezeichnung = value;
                }
            }
        }

        public Guid Code
        {
            get
            {
                return _code;
            }
        }

        public decimal Preis
        {
            get
            {
                return _preis;
            }
            set
            {
                if(!(value < 0))
                {
                    _preis = value;
                }
            }
        }

        public ArtikelStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        #endregion

        #region Constructors

        public Artikel()
        {
            _bezeichnung = "Apfel";
            _code = Guid.NewGuid();
            _preis = 0.01m;
            _status = ArtikelStatus.Available;
        }

        #endregion

        #region Methods

        public string GetInfoString()
        {
            return $"Artikel {_bezeichnung}({_code}) besitzt den Status {_status} und Kostet {_preis}EUR.";
        }

        #endregion
    }
}