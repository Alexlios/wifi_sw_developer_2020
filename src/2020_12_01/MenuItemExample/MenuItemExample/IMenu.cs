namespace MenuItemExample
{
    interface IMenu<T>
    {
        int Count { get; }

        void Add(IMenuItem<T> menuItem);
        void Remove(IMenuItem<T> menuItem);
        void Display(int width);
        IMenuItem<T> SelectItem(string inputPrompt);
    }
}
