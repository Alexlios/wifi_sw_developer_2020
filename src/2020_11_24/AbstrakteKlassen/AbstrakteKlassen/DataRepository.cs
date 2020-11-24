using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    public abstract class DataRepository
    {
        #region PrivateFields

        private string _name;
        private int _maxSize;

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int MaxSize
        {
            get
            {
                return _maxSize;
            }
            set
            {
                _maxSize = value;
            }
        }

        #endregion

        #region Constructors

        public DataRepository(string name, int maxSize)
        {
            _name = name;
            _maxSize = maxSize;
        }

        #endregion

        #region AbstractMethods

        public abstract string Read();

        public abstract void Write(string data);

        #endregion
    }
}
