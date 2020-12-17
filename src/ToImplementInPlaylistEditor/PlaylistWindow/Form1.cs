using Playlist;
using System;
using System.Windows.Forms;

namespace PlaylistWindow
{
    public partial class Form1 : Form
    {
        private IPlaylist _playlist;
        private readonly INewPlaylistCreator _newPlaylistCreator;
        private readonly IPlaylistItemFactory _playlistItemFactory;

        public Form1(INewPlaylistCreator newPlaylistCreator,IPlaylistItemFactory playlistItemFactory)
        {
            InitializeComponent();

            _newPlaylistCreator = newPlaylistCreator;
            _playlistItemFactory = playlistItemFactory;
        }

        private void NewPlaylist_Click(object sender, EventArgs e)
        {
            if (_newPlaylistCreator.StartDialog() != DialogResult.OK)
            {
                return;
            }

            var title = _newPlaylistCreator.Title;
            var author = _newPlaylistCreator.Author;

            _playlist = new Playlist.Playlist(title, author, DateTime.Now);

            UpdatePlaylistDetails();
            UpdatePlaylistItems();
        }

        private void UpdatePlaylistItems()
        {
            int index = 0;
            listView1.Clear();
            imageList1.Images.Clear();

            foreach (var item in _playlist.Items)
            {
                ListViewItem lvi = new ListViewItem(item.ToString());
                lvi.ImageIndex = index++;
                lvi.Tag = item;
                imageList1.Images.Add(item.Thumbnail);

                listView1.Items.Add(lvi);
            }

            listView1.LargeImageList = imageList1;
        }

        private void UpdatePlaylistDetails()
        {
            label1.Text = _playlist.Name;
            label2.Text = _playlist.Author;
            label3.Text = _playlist.CreationDateString;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            foreach (var file in openFileDialog1.FileNames)
            {
                var item = _playlistItemFactory.Create(file);
                if(item != null)
                {
                    _playlist.Add(item);
                }
            }
        }
    }
}
