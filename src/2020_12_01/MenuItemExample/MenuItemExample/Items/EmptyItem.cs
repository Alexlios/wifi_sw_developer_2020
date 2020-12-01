using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample.Items
{
    class EmptyItem<T> : IMenuItem<T>
    {
        public string Description
        {
            get
            {
                return string.Empty;
            }
        }

        public ConsoleKey Code
        {
            get
            {
                return ConsoleKey.Sleep;
            }
        }

        public bool Selectable
        {
            get
            {
                return false;
            }
        }

        public bool Visible
        {
            get
            {
                return true;
            }
        }

        public virtual void Display(int width)
        {
            Console.WriteLine();
        }

        public void Execute(T executionParameter)
        {
            //nothing to do
        }
    }
}
