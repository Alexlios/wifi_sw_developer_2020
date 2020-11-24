using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    public class ColoredMenuItem : MenuItem
    {
        private ConsoleColor _itemColor;

        public ConsoleColor ItemColor
        {
            get
            {
                return _itemColor;
            }
            set
            {
                _itemColor = value;
            }
        }


        public ColoredMenuItem(string description, char code) : base(description, code)
        {
            _itemColor = Console.ForegroundColor;
        }

        public ColoredMenuItem(string description, char code, ConsoleColor itemColor) : base(description, code)
        {
            _itemColor = itemColor;
        }

        public override void Display(int width)
        {
            ConsoleColor tmp = Console.ForegroundColor;
            Console.ForegroundColor = _itemColor;
            base.Display(width);
            Console.ForegroundColor = tmp;
        }
    }
}
