using System;

namespace MenuItemExample
{
    public interface IMenuItem
    {
        #region Properties

        string Description { get; }
        ConsoleKey Code { get; }
        bool Selectable { get; }
        bool Visible { get; }

        #endregion

        #region Methods

        void Display(int width);
        void Action();

        #endregion
    }

    public interface IMenuItemUpdateSelectable : IMenuItem
    {
        new bool Selectable { get; set; }
    }
}