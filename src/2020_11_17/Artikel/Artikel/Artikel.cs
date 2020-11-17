using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artikel
{
    class Artikel
    {
        #region PrivateFields

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
                if(!string.IsNullOrEmpty(value))
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
            _bezeichnung = "undefined";
            _code = Guid.NewGuid();
            _preis = 0;
            _status = ArtikelStatus.Unknown;
        }

        public Artikel(string bezeichnung, decimal preis, ArtikelStatus status)
        {
            Bezeichnung = bezeichnung;
            _code = Guid.NewGuid();
            Preis = preis;
            Status = status;
        }

        #endregion

        #region PublicMethods

        public string GetInfo()
        {
            return $"Der Artikel {_bezeichnung}({_code}) kostet {_preis}EUR und hat den Status: {_status}.";
        }

        #endregion
    }
}
