using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    public class Menu : IMenu
    {
        private int _count;
        private SortedList<int, IMenuItem> _itemList;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public Menu()
        {
            _count = 0;
            _itemList = new SortedList<int, IMenuItem>();
        }

        public Menu(SortedList<int, IMenuItem> itemList)
        {
            _itemList = itemList;
            _count = itemList.Count;
        }

        public void Add(IMenuItem menuItem)
        {
            _itemList.Add(_count++, menuItem);
        }

        public void Remove(IMenuItem menuItem)
        {
            _itemList.Remove(_itemList.IndexOfValue(menuItem));
            --_count;
        }

        public void Display(int width)
        {
            foreach (IMenuItem item in _itemList.Values)
            {
                item.Display(width);
            }
        }

        public IMenuItem SelectItem(string inputPrompt)
        {
            ConsoleKeyInfo input;
            IMenuItem result;

            while (true)
            {
                Console.Write(inputPrompt);
                input = Console.ReadKey(true);

                result = SelectByKey(input.Key);

                if (result.Description != string.Empty)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine($"Menüoption {input.KeyChar} nicht gefunden");
                }

            }
        }

        private IMenuItem SelectByKey(ConsoleKey code)
        {
            IMenuItem result = new EmptyItem();

            foreach (IMenuItem item in _itemList.Values)
            {
                if (item.Code == code && item.Visible)
                {
                    result = item;
                    break;
                }
            }

            return result;
        }
    }
}
