using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaylistWindow
{
    public partial class Form1 : Form
    {
        private Playlist.IPlaylist _playlist;

        public Form1()
        {
            InitializeComponent();
        }

        private void NewPlaylist_Click(object sender, EventArgs e)
        {
            var createPlaylistDialog = new NewPlaylist();

            if (createPlaylistDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _playlist = new Playlist.Playlist(createPlaylistDialog.Title, createPlaylistDialog.Author, DateTime.Now);

            UpdatePlaylistDetails();
            UpdatePlaylistItems();
        }

        private void UpdatePlaylistItems()
        {
            int index = 0;
            listView1.Clear();
            imageList1.Images.Clear();

            foreach(var item in _playlist.Items)
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
            if(openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            foreach(var file in openFileDialog1.FileNames)
            {
                var item = new Mp3Item();
                _playlist.Add(item);
                UpdatePlaylistDetails();
                UpdatePlaylistItems();
            }
        }
    }
}
