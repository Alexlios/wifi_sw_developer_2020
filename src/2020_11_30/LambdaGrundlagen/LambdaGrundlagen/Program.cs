using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaGrundlagen
{
    public delegate void DoSomethingHandler(string msg);

    class Program
    {
        static void Main(string[] args)
        {
            DoSomethingHandler myAction = DisplayMessage;
            int test = 0;
            myAction("Hello World");


            myAction = delegate (string userText)
            {
                Console.WriteLine("Bruder: " + userText);
                test++;
            };

            myAction("Hi " + test);
            myAction("Bye " + test);

            myAction = (string userText) =>
            {
                Console.WriteLine("Schwester");
            };
            myAction("");

            myAction = x => Console.WriteLine("Ja geil");
            myAction("");
        }

        static void DisplayMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
