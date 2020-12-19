using System;
using System.Collections.Generic;
using IPlaylistItem;

namespace Playlist
{
    public interface IPlaylist
    {
        string Author { get; set; }
        int Count { get; }
        DateTime CreatedAt { get; set; }
        string CreationDateString { get; }
        TimeSpan Duration { get; }
        IEnumerable<IPlaylistItem.IPlaylistItem> Items { get; }
        string Name { get; set; }

        void Add(IPlaylistItem.IPlaylistItem newItem);
        void Clear();
        void Remove(IPlaylistItem.IPlaylistItem newItem);
    }
}