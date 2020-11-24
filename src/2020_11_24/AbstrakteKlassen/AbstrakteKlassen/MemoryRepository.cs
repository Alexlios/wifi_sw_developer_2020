using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    public class MemoryRepository : DataRepository
    {
        #region PrivateFields

        private string _myMemory;

        #endregion
        
        #region Constructors

        public MemoryRepository(int maxSize) : base("RAM Repository", maxSize) { }

        #endregion

        #region PublicMethods

        public override string Read()
        {
            return _myMemory;
        }

        public override void Write(string data)
        {
            if(data.Length > MaxSize)
            {
                Debug.WriteLine($"Achtung! Daten grösser als MaxSize: {data.Length} Zeichen");
                _myMemory = data.Substring(0, MaxSize);
            }

            _myMemory = data.Substring(0, data.Length);

        }
        
        #endregion
    }
}
