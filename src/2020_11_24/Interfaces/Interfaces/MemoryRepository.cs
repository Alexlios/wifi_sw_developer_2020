using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    public class MemoryRepository : IDataRepository
    {
        #region PrivateFields

        private readonly string _name;
        private readonly int _maxSize;
        private string _myMemory;

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int MaxSize
        {
            get
            {
                return _maxSize;
            }
        }

        #endregion

        #region Constructors

        public MemoryRepository(int maxSize)
        {
            _name = "RAM Repository";
            _maxSize = maxSize;
            _myMemory = string.Empty;
        }

        #endregion

        #region PublicMethods

        public string Read()
        {
            return _myMemory;
        }

        public void Write(string data)
        {
            if(data.Length > _maxSize)
            {
                Debug.WriteLine($"Achtung! Daten grösser als MaxSize: {data.Length} Zeichen");
                _myMemory = data.Substring(0, _maxSize);
            }

            _myMemory = data.Substring(0, data.Length);

        }
        
        #endregion
    }
}
