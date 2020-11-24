using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    class EmptyItem : IMenuItem
    {
        private readonly string _description;
        private readonly char _code;


        public string Description
        {
            get
            {
                return _description;
            }
        }

        public char Code
        {
            get
            {
                return _code;
            }
        }

        public EmptyItem()
        {
            _description = "EmptyItem";
            _code = '0';
        }

        public virtual void Display(int width)
        {
            Console.WriteLine();
        }
    }
}
