using System;

namespace MenuItemExample
{
    public interface IMenuItem
    {
        #region Properties

        string Description { get; }
        ConsoleKey Code { get; }
        bool Selectable { get; set; }
        bool Visible { get; set; }

        #endregion

        #region Methods

        void Display(int width);
        void Action();

        #endregion
    }
}