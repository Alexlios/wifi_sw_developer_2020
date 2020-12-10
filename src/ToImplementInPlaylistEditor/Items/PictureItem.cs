using IPlaylistItem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class PictureItem : IPlaylistItem.IPlaylistItem
    {
        #region PrivateFields

        private string _title;
        private string _artist;
        private TimeSpan _duration;
        private string _path;
        private Image _thumbnail;

        #endregion

        #region Properties

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Artist
        {
            get => _artist;
            set => _artist = value;
        }

        public TimeSpan Duration
        {
            get => _duration;
            set => _duration = value;
        }

        public string Path
        {
            get => _path;
            set => _path = value;
        }

        public Image Thumbnail
        {
            get => _thumbnail;
            set => _thumbnail = value;
        }

        #endregion

        #region Constructors

        PictureItem(string path)
        {
            _path = path;

            ReadIdv3TagsFromFile();
        }


        #endregion

        #region PublicMethods



        #endregion

        #region PrivateMethods


        private void ReadIdv3TagsFromFile()
        {

        }

        #endregion
    }
}
