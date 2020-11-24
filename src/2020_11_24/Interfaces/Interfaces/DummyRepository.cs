using AbstrakteKlassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class DummyRepository : IDataRepository
    {
        #region Properties

        public string Name => throw new NotImplementedException();

        public int MaxSize => throw new NotImplementedException();

        #endregion

        #region PublicMethods

        public string Read()
        {
            throw new NotImplementedException();
        }

        public void Write(string data)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
