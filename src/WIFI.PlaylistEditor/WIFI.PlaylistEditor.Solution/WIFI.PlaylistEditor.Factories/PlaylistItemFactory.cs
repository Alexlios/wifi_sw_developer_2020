using System.IO;
using WIFI.PlaylistEditor.Items;
using WIFI.PlaylistEditor.Types;

namespace WIFI.PlaylistEditor.Factories
{
    public class PlaylistItemFactory : IPlaylistItemFactory
    {
        public IPlaylistItem Create(string filePath)
        {
            IPlaylistItem playlistItem = null;

            if (string.IsNullOrWhiteSpace(filePath))
            {
                return playlistItem;
            }

            var extension = Path.GetExtension(filePath);

            switch (extension)
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
