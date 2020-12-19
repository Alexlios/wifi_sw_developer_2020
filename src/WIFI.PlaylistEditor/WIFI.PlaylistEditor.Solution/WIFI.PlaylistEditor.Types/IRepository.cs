namespace WIFI.PlaylistEditor.Types
{
    public interface IRepository : IFileIdentifier
    {

        void Save(string filePath, IPlaylist playlist);

        IPlaylist Load(string filePath);
    }
}