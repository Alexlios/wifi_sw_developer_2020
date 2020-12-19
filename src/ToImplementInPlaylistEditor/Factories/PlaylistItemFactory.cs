using Items;
using Playlist;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories
{
    public class PlaylistItemFactory : IPlaylistItemFactory
    {
        public IPlaylistItem.IPlaylistItem Create(string filePath)
        {
            IPlaylistItem.IPlaylistItem playlistItem = null;

            if(string.IsNullOrWhiteSpace(filePath))
            {
                return playlistItem;
            }

            var extension = Path.GetExtension(filePath);

            switch(extension)
            {
                case ".mp3":
                    playlistItem = new Mp3Item(filePath);
                    break;

                default:
                    playlistItem = null;
                    break;
            }

            return playlistItem;
        }
    }
}
