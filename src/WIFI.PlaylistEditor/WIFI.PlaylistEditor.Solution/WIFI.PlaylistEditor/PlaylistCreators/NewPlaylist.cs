using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIFI.PlaylistEditor.PlaylistCreators
{
    public partial class NewPlaylist : Form
    {
        public NewPlaylist()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => PlaylistName.Text;
        }

        public string Author
        {
            get => PlaylistAutor.Text;
        }

        public DialogResult StartDialog()
        {
            return ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PlaylistName.Text) || string.IsNullOrWhiteSpace(PlaylistAutor.Text))
            {
                MessageBox.Show("Ein Feld war leer", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }

        }
    }
}
