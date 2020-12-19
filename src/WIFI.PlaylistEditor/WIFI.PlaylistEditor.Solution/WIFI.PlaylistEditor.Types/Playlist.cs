using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIFI.PlaylistEditor.Types
{
    public class Playlist : IPlaylistRepository
    {
        #region PrivateFields

        private string _description;
        private List<IPlaylistItems> _itemList;

        #endregion

        #region Properties

        public string Description
        {
            get
            {
                return _description;
            }
        }

        public List<IPlaylistItems> ItemsList
        {
            get
            {
                return _itemList;
            }
        }

        #endregion

        #region PublicMethods

        public void Load()
        {
            //TODO
        }

        public void Save()
        {
            //TODO
        }

        public void Add(IPlaylistItems toAdd)
        {
            _itemList.Add(toAdd);
        }

        public void Remove(IPlaylistItems toRemove)
        {
            _itemList.Remove(toRemove);
        }

        public void Clear()
        {
            _itemList = new List<IPlaylistItems>();
        }

        #endregion
    }
}
