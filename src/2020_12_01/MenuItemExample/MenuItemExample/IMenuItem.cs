using System;

namespace MenuItemExample
{
    public interface IMenuItem<T>
    {
        #region Properties

        string Description { get; }
        ConsoleKey Code { get; }
        bool Selectable { get; }
        bool Visible { get; }

        #endregion

        #region Methods

        void Display(int width);

        void Execute(T executionParameter);

        #endregion
    }

    public interface IMenuItemUpdateSelectable<T> : IMenuItem<T>
    {
        new bool Selectable { get; set; }
    }
}