using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenGrundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration + Initialisierung
            int i = int.MaxValue;
            Console.WriteLine("int(32)\tMaxValue:\t" + i + "\t\t\tMinValue:\t" + int.MinValue);


            //float, double & decimal
            float f = float.MaxValue;
            double d = double.MaxValue;
            decimal de = decimal.MaxValue;//decimal Bsp: de = 15.50M
            Console.WriteLine("float\tMaxValue:\t" + f + "\t\t\tMinValue:\t" + float.MinValue);
            Console.WriteLine("double\tMaxValue:\t" + d + "\t\tMinValue:\t" + double.MinValue);
            Console.WriteLine("decimal\tMaxValue:\t" + de + "\tMinValue:\t" + decimal.MinValue);


            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------\n");


            //string
            string s = "SampleText";
            Console.WriteLine("string\tText:\t\t" + s + "\t\t\tLaenge:\t\t" + s.Length);


            //char
            char c = s[0];
            Console.WriteLine("char\tText:\t\t" + c + "\t\t\t\tLaenge:\t\t1");


            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------\n");


            //bool
            bool b = true;
            Console.WriteLine("bool\tWert:\t\t" + b + "\t\t\t\tGegenwert:\t" + !b);


            Console.WriteLine();
        }
    }
}
