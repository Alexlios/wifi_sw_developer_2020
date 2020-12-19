using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIFI.PlaylistEditor.PlaylistCreators
{
    public class DummyCreator : INewPlaylistCreator
    {
        public string Author => "Gandalf der Weise";

        public string Title => "Hardcodierte Playlist";

        public DialogResult StartDialog()
        {
            return DialogResult.OK;
        }
    }
}
