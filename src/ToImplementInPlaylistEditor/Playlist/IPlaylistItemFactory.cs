using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    public interface IPlaylistItemFactory
    {
        IPlaylistItem.IPlaylistItem Create(string filePath);
    }
}
