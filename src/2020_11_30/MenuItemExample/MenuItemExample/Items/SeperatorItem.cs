using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample.Items
{
    class SeperatorItem : MenuItem
    {
        private char _separator;

        public char Separator
        {
            get
            {
                return _separator;
            }
            set
            {
                _separator = value;
            }
        }

        public SeperatorItem(char separator)
            : base("", ConsoleKey.Enter, false, true)
        {
            _separator = separator;
        }

        public SeperatorItem(char separator,bool visible)
            : base("", ConsoleKey.Enter, false, visible)
        {
            _separator = separator;
        }

        public override void Display(int width)
        {
            if(Visible)
            {
                Console.WriteLine(new string(_separator, width + 2));
            }
        }
    }
}
