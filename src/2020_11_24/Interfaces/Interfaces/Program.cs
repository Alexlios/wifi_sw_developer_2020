using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataRepository repos = new TextFileRepository("./Test.txt",20);

            PersistMyDate(repos, "TestSchmest");

            Console.WriteLine(repos.Read());
        }

        static void PersistMyDate(IDataRepository repository, string dataToPersist)
        {
            if(repository != null)
            {
                repository.Write(dataToPersist);
            }
        }
    }
}
