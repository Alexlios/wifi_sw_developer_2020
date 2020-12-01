using MenuItemExample.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    public class Menu<T> : IMenu<T>
    {
        private int _count;
        private SortedList<int, IMenuItem<T>> _itemList;

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
            _itemList = new SortedList<int, IMenuItem<T>>();
        }

        public Menu(SortedList<int, IMenuItem<T>> itemList)
        {
            _itemList = itemList;
            _count = itemList.Count;
        }

        public void Add(IMenuItem<T> menuItem)
        {
            _itemList.Add(_count++, menuItem);
        }

        public void Remove(IMenuItem<T> menuItem)
        {
            _itemList.Remove(_itemList.IndexOfValue(menuItem));
            --_count;
        }

        public void Display(int width)
        {
            foreach (IMenuItem<T> item in _itemList.Values)
            {
                item.Display(width);
            }
        }

        public IMenuItem<T> SelectItem(string inputPrompt)
        {
            ConsoleKeyInfo input;
            IMenuItem<T> result;

            while (true)
            {
                Console.Write(inputPrompt);
                input = Console.ReadKey(true);
                Console.WriteLine();

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

        private IMenuItem<T> SelectByKey(ConsoleKey code)
        {
            IMenuItem<T> result = new EmptyItem<T>();

            foreach (IMenuItem<T> item in _itemList.Values)
            {
                if (item.Code == code && item.Selectable)
                {
                    result = item;
                    break;
                }
            }

            return result;
        }
    }
}
