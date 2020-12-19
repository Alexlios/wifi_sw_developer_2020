using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIFI.PlaylistEditor.PlaylistCreators
{
    public interface INewPlaylistCreator
    {
        string Author { get; }
        string Title { get; }

        DialogResult StartDialog();
    }
}
