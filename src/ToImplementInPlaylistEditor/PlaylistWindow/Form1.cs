using Playlist;
using PlaylistWindow.Properties;
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

            EnableItemCommands();
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
                imageList1.Images.Add((item.Thumbnail != null) ? item.Thumbnail : Resources.Missing);

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

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            label4.Text = string.Empty;

            EnableItemCommands(false);
        }

        private void EnableItemCommands()
        {
            EnableItemCommands(true);
        }

        private void EnableItemCommands(bool enabled)
        {
            button2.Enabled = enabled;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = string.Empty;

            foreach(ListViewItem item in listView1.SelectedItems)
            {
                var playlistItem = item.Tag as IPlaylistItem.IPlaylistItem;
                if(playlistItem != null)
                {
                    label4.Text += $"Artist: {playlistItem.Artist} | Titel: {playlistItem.Title} | " +
                        $"Dauer: {playlistItem.Duration.ToString(@"hh\:mm\:ss")} | {playlistItem.Path}";

                }
            }
        }
    }
}
