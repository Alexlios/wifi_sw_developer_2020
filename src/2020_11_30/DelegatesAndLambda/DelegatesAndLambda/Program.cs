using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambda
{
    //Type Specification
    public delegate void DoSomethingHandler(string message);

    class Program
    {
        static void Main(string[] args)
        {
            DoSomethingHandler myAction = DisplayMessage;
            myAction("blub");
            DoesMethodWork(myAction);
        }

        static bool DoesMethodWork(DoSomethingHandler displayMethod)
        {
            bool result = false;

            try
            {
                displayMethod("Test");
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        static void DisplayMessage(string userMessage)
        {
            Console.WriteLine(userMessage);
        }
    }
}
