using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    public class TextFileRepository : IDataRepository
    {
        #region PrivateFields

        private readonly string _name;
        private readonly int _maxSize;
        private string _fileName;

        #endregion

        #region Properties

        public string FileName
        {
            get
            {
                return _fileName;
            }
        }

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

        public TextFileRepository(string fileName, int maxSize)
        {
            _name = "TextFile Repository";
            _maxSize = maxSize;
            _fileName = fileName;
        }

        #endregion

        #region PublicMethods

        public string Read()
        {
            if (string.IsNullOrWhiteSpace(_fileName) || !File.Exists(_fileName))
            {
                Debug.WriteLine($"Dateiname '{_fileName}' darf nicht leer oder nicht vorhanden sein.");
                return string.Empty; ;
            }
            using (StreamReader sr = new StreamReader(_fileName))
            {
                return sr.ReadToEnd();
            }
        }

        public void Write(string data)
        {
            if(string.IsNullOrWhiteSpace(_fileName))
            {
                Debug.WriteLine($"Dateiname '{_fileName}' darf nicht leer sein.");
                return;
            }

            using(StreamWriter sw = new StreamWriter(_fileName, true))
            {
                sw.WriteLine(data);
            }
        }

        #endregion
    }
}
