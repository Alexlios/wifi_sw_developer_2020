using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIFI.PlaylistEditor.Types
{
    public interface IPlaylistItemFactory
    {
        IPlaylistItem Create(string filePath);
    }
}
