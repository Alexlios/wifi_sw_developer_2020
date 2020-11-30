using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample.Items
{
    public class MenuItem : IMenuItemUpdateSelectable
    {
        #region PrivateFields

        private readonly string _description;
        private readonly ConsoleKey _code;
        private bool _selectable;
        private bool _visible;

        #endregion

        #region Properties

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

        public bool Selectable
        {
            get
            {
                return _selectable;
            }
            set
            {
                _selectable = value;
            }
        }

        public bool Visible
        {
            get
            {
                return _visible;
            }
        }

        #endregion

        #region Constructors

        public MenuItem(string description, ConsoleKey code)
        {
            _description = description;
            _code = code;
            _selectable = true;
            _visible = true;
        }

        public MenuItem(string description, ConsoleKey code, bool selectable, bool visible)
        {
            _description = description;
            _code = code;
            _selectable = selectable;
            _visible = visible;
        }

        #endregion

        #region PublicMethods

        public virtual void Display(int width)
        {
            if(_visible)
            {
                Console.WriteLine(_description + GetSpacer(width) + _code);
            }
        }

        public void Action()
        {
        }

        #endregion

        #region PrivateMethods

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
        
        #endregion
    }
}
