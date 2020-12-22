using System;
using System.Windows.Forms;
using Wifi.PlaylistEditor.Repositories.MongoDb;
using Wifi.PlaylistEditor.Repositories.MongoDb.Core;
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
        private readonly IRepositoryFactory _repositoryFactory;

        public EditorWindow(INewPlaylistCreator newPlaylistCreator,
                            IPlaylistItemFactory playlistItemFactory,
                            IRepositoryFactory repositoryFactory)
        {
            InitializeComponent();

            _newPlaylistCreator = newPlaylistCreator;
            _playlistItemFactory = playlistItemFactory;
            _repositoryFactory = repositoryFactory;
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
                imageList1.ImageSize = new System.Drawing.Size(64, 64);

                listView1.Items.Add(lvi);
            }

            listView1.LargeImageList = imageList1;
        }

        private void UpdatePlaylistDetails()
        {
            PlaylistInfo.Text = "Playlist Info:\n" + _playlist.Name;
            PlaylistInfo.Text += "\nAutor: " + _playlist.Author;
            PlaylistInfo.Text += "\nErstellt am: " + _playlist.CreationDateString;
            PlaylistInfo.Text += "\nGesamtdauer: " + _playlist.Duration.ToString(@"hh\h\:mm\m\:ss\s");
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
                TrackInfo.Text += $"Artist: {playlistItem.Artist} \nTitel: {playlistItem.Title} \n" +
                    $"Dauer: {playlistItem.Duration.ToString(@"hh\h\:mm\m\:ss\s")}";

            }
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

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "MP3 File (*.mp3)|*.mp3";
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

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "M3U File (*.m3u)|*.m3u";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            IRepository repository = _repositoryFactory.Create(openFileDialog1.FileName);
            if(repository != null)
            {
                _playlist = repository.Load(openFileDialog1.FileName);


                EnableItemCommands();
                UpdatePlaylistDetails();
                UpdatePlaylistItems();
            }
        }

        private void playlistToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "M3U File (*.m3u)|*.m3u";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            IRepository repository = _repositoryFactory.Create(saveFileDialog1.FileName);
            repository.Save(saveFileDialog1.FileName, _playlist);

            UpdatePlaylistDetails();
            UpdatePlaylistItems();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDatabaseRepository databaseRepository = new MongoDbRepository(_playlistItemFactory);

            databaseRepository.Save(_playlist.Name, _playlist);

            MessageBox.Show("Playlist wurde gespeichert", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
