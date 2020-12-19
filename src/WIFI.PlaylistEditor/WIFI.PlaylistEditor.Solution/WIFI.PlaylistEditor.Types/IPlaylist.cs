using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIFI.PlaylistEditor.Types
{
    public interface IPlaylist
    {
        string Author { get; set; }
        int Count { get; }
        DateTime CreatedAt { get; set; }
        string CreationDateString { get; }
        TimeSpan Duration { get; }
        IEnumerable<IPlaylistItem> Items { get; }
        string Name { get; set; }

        void Add(IPlaylistItem newItem);
        void Clear();
        void Remove(IPlaylistItem newItem);
    }
}
