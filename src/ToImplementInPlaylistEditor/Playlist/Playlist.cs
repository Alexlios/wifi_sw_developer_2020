using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    public class Playlist
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

        public TimeSpan Duration
        {
            get
            {
                var result = TimeSpan.Zero;

                if(_items != null)
                {
                    foreach (var item in _items)
                    {
                        result += item.Duration;
                    }
                }

                return result;
            }
        }

        public IEnumerable<IPlaylistItem.IPlaylistItem> Items
        {
            get => _items;
        }

        #endregion

    }
}
