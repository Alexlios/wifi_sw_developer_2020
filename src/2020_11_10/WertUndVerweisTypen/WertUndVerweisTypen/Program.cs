using System;
using WIFI.ToolLibrary.ConsoleIO;

namespace WertUndVerweisTypen
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();

            myBook.Title = "Die unendliche Geschichte";
            myBook.Author = "Michael Ende";
            myBook.Price = 15.99m;

            //das Buch kopieren
            Book myNewBook = myBook;

            //das Buch ändern
            


            DisplayBookInfos(myBook);
            DisplayBookInfos(myNewBook);
        }

        /// <summary>
        /// Displays a book
        /// </summary>
        /// <param name="bookToDisplay">Book that will be displayed</param>
        static void DisplayBookInfos(Book bookToDisplay)
        {
            ConsoleTools.DisplayMesssage($"'{bookToDisplay.Title.ToUpper()}' von {bookToDisplay.Author} => EUR {bookToDisplay.Price}", ConsoleColor.Green);
            bookToDisplay.Title = "Vom Mythos des Mann-Monats";
        }
    }
}
