using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    public class Playlist : IPlaylist
    {
        #region PrivateFields

        private string _name;
        private string _author;
        private DateTime _createdAt;
        private List<IPlaylistItem.IPlaylistItem> _items;

        #endregion

        #region Properties

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Author
        {
            get => _author;
            set => _author = value;

        }

        public DateTime CreatedAt
        {
            get => _createdAt;
            set => _createdAt = value;
        }

        public string CreationDateString
        {
            get
            {
                return _createdAt.ToShortDateString() + " " + _createdAt.ToShortTimeString();
            }
        }

        public TimeSpan Duration
        {
            get
            {
                var result = TimeSpan.Zero;

                foreach (var item in _items)
                {
                    result += item.Duration;
                }

                return result;
            }
        }

        public IEnumerable<IPlaylistItem.IPlaylistItem> Items
        {
            get => _items;
        }

        public int Count
        {
            get => _items.Count;
        }

        #endregion

        #region Constructors

        public Playlist(string name, string author, DateTime createdAt)
        {
            _name = name;
            _author = author;
            _createdAt = createdAt;

            _items = new List<IPlaylistItem.IPlaylistItem>();
        }

        #endregion

        #region PublicMethods

        public void Add(IPlaylistItem.IPlaylistItem newItem)
        {
            _items.Add(newItem);
        }

        public void Remove(IPlaylistItem.IPlaylistItem newItem)
        {
            _items.Remove(newItem);
        }

        public void Clear()
        {
            _items.Clear();
        }

        #endregion
    }
}
