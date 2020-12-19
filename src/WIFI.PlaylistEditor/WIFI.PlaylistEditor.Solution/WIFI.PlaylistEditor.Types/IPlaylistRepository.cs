namespace WIFI.PlaylistEditor.Types
{
    public interface IPlaylistRepository
    {
        #region Properies

        //Extension

        string Description
        {
            get;
        }

        #endregion

        #region Methods

        void Load();

        void Save();

        #endregion
    }
}