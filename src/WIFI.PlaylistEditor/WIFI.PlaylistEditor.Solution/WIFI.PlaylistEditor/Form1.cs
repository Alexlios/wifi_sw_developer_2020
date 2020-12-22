using System;
using System.Windows.Forms;
using WIFI.PlaylistEditor.PlaylistCreators;
using WIFI.PlaylistEditor.Properties;
using WIFI.PlaylistEditor.Types;

namespace WIFI.PlaylistEditor
{
    public partial class EditorWindow : Form
    {
        private IPlaylist _playlist;
        private readonly INewPlaylistCreator _newPlaylistCreator;
        private readonly IPlaylistItemFactory _playlistItemFactory;

        public EditorWindow(INewPlaylistCreator newPlaylistCreator, IPlaylistItemFactory playlistItemFactory)
        {
            InitializeComponent();

            _newPlaylistCreator = newPlaylistCreator;
            _playlistItemFactory = playlistItemFactory;
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
                imageList1.Images.Add((item.Thumbnail != null) ? item.Thumbnail : Resources.Missing);

                listView1.Items.Add(lvi);
            }

            listView1.LargeImageList = imageList1;
        }

        private void UpdatePlaylistDetails()
        {
            PlaylistInfo.Text = "Playlist Info:\n" + _playlist.Name;
            PlaylistInfo.Text += "\nAutor: " + _playlist.Author;
            PlaylistInfo.Text += "\nErstellt am: " + _playlist.CreationDateString;
            PlaylistInfo.Text += "\nGesamtdauer: " + _playlist.Duration.ToString("hh:mm");
        }

        private void EnableItemCommands()
        {
            EnableItemCommands(true);
        }

        private void EnableItemCommands(bool enabled)
        {
            ItemsButton.Enabled = enabled;
        }

        private IPlaylistItem GetSelectedPlaylistItem()
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                return item.Tag as IPlaylistItem;
            }

            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlaylistInfo.Text = "Playlist Info:";
            TrackInfo.Text = "Track Info:";

            EnableItemCommands(false);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrackInfo.Text = "Track Info:\n";

            var playlistItem = GetSelectedPlaylistItem();
            if (playlistItem != null)
            {
                TrackInfo.Text += $"Artist: {playlistItem.Artist} | Titel: {playlistItem.Title} | " +
                    $"Dauer: {playlistItem.Duration.ToString(@"hh\:mm\:ss")} | {playlistItem.Path}";

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            foreach (var file in openFileDialog1.FileNames)
            {
                var item = _playlistItemFactory.Create(file);
                if (item != null)
                {
                    _playlist.Add(item);
                }
            }

            UpdatePlaylistDetails();
            UpdatePlaylistItems();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_newPlaylistCreator.StartDialog() != DialogResult.OK)
            {
                return;
            }

            var title = _newPlaylistCreator.Title;
            var author = _newPlaylistCreator.Author;

            _playlist = new Playlist(title, author, DateTime.Now);

            EnableItemCommands();
            UpdatePlaylistDetails();
            UpdatePlaylistItems();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var playlistItem = GetSelectedPlaylistItem();
            if (playlistItem != null)
            {
                _playlist.Remove(playlistItem);

                UpdatePlaylistDetails();
                UpdatePlaylistItems();
            }
        }
    }
}
