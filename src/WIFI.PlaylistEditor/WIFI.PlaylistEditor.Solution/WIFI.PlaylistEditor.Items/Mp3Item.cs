using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using WIFI.PlaylistEditor.Types;

namespace WIFI.PlaylistEditor.Items
{
    public class Mp3Item : IPlaylistItem
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

        public Mp3Item(string path)
        {
            _path = path;

            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                InitFieldsWithEmpty();
                return;
            }

            ReadIdv3TagsFromFile();
        }

        private void InitFieldsWithEmpty()
        {
            _title = "--[File not found]--";
            _artist = string.Empty;
            _duration = TimeSpan.Zero;
            _thumbnail = null;
        }


        #endregion

        #region PublicMethods

        public override string ToString()
        {
            return _artist + _title;
        }

        #endregion

        #region PrivateMethods


        private void ReadIdv3TagsFromFile()
        {
            var tfile = TagLib.File.Create(_path);

            _title = tfile.Tag.Title;
            _duration = tfile.Properties.Duration;
            _artist = tfile.Tag.FirstPerformer;

            if (tfile.Tag.Pictures != null && tfile.Tag.Pictures.Length > 0)
            {
                _thumbnail = Image.FromStream(new MemoryStream(tfile.Tag.Pictures[0].Data.Data));
            }
            else
            {
                _thumbnail = null;
                Debug.WriteLine($"{System.IO.Path.GetFileName(_path)} macht Probleme!");
            }
        }

        #endregion
    }
}
