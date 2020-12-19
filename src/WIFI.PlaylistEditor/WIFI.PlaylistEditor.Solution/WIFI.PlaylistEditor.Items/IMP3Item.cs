using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIFI.PlaylistEditor.Items
{
    public interface IMP3Item
    {
        #region Properties

        string Titel
        {
            get;
        }

        string Artist
        {
            get;
        }

        TimeSpan Duration
        {
            get;
        }

        string Path
        {
            get;
        }
        Image Thumbnail
        {
            get;
        }

        #endregion
    }
}
