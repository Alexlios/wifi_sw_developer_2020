using System.Windows.Forms;

namespace PlaylistWindow
{
    public interface INewPlaylistCreator
    {
        string Author { get; }
        string Title { get; }

        DialogResult StartDialog();
    }
}