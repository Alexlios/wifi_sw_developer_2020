using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlaylistItem
{
    public interface IPlaylistItem
    {
        string Title
        {
            get;
            set;
        }

        string Artist
        {
            get;
            set;
        }

        TimeSpan Duration
        {
            get;
            set;
        }

        string Path
        {
            get;
            set;
        }

        Image Thumbnail
        {
            get;
            set;
        }
    }
}
