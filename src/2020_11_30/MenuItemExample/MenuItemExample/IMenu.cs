namespace MenuItemExample
{
    interface IMenu
    {
        int Count { get; }

        void Add(IMenuItem menuItem);
        void Remove(IMenuItem menuItem);
        void Display(int width);
        IMenuItem SelectItem(string inputPrompt);
    }
}
