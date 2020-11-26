using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    public class MenuItem : IMenuItem
    {
        private readonly string _description;
        private readonly ConsoleKey _code;


        public string Description
        {
            get
            {
                return _description;
            }
        }

        public ConsoleKey Code
        {
            get
            {
                return _code;
            }
        }


        public MenuItem(string description, ConsoleKey code)
        {
            _description = description;
            _code = code;
        }

        public virtual void Display(int width)
        {
            Console.WriteLine(_description + GetSpacer(width) + _code);
        }

        private string GetSpacer(int width)
        {
            width -= _description.Length;
            string result = string.Empty;
            for (int i = 0; i < width; i++)
            {
                result += '.';
            }
            return result;
        }

        public void Action()
        {
        }
    }
}
