using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    public interface IDataRepository
    {
        #region Properties

        string Name
        {
            get;
        }

        int MaxSize
        {
            get;
        }

        #endregion

        #region Methods

        string Read();

        void Write(string data);

        #endregion
    }
}
