using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample.Items
{
    public class ColoredMenuItem<T> : MenuItem<T>
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

        public ColoredMenuItem(string description, ConsoleKey code, Action<T> action, ConsoleColor itemColor) : base(description, code, action)
        {
            _itemColor = itemColor;
        }

        public ColoredMenuItem(string description, ConsoleKey code, Action<T> action, ConsoleColor itemColor, bool selectable, bool visible) : base(description, code, action, selectable, visible)
        {
            _itemColor = itemColor;
        }

        public override void Display(int width)
        {
            if(Visible)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = _itemColor;
                base.Display(width);
                Console.ForegroundColor = tmp;
            }
        }
    }
}
