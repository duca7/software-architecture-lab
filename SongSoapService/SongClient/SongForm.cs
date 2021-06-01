using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongClient
{
    public partial class SongForm : Form
    {

        gearhost.SongService songService = new gearhost.SongService();
        public SongForm()
        {
            InitializeComponent();
        }

        private void SongForm_Load(object sender, EventArgs e)
        {
            List<gearhost.Song> songs = songService.GetAll().ToList();
            gridSong.DataSource = songs;
        }

        private void gridSong_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowCount = gridSong.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                int code = int.Parse(gridSong.SelectedRows[0].Cells["Id"].Value.ToString());
                gearhost.Song song = songService.GetDetails(code);
                if (song != null)
                {
                    txtId.Text = song.Id.ToString();
                    txtTitle.Text = song.Title;
                    txtSinger.Text = song.Singer;
                    txtAlbum.Text = song.Album;
                    txtGenre.Text = song.Genre;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<gearhost.Song> songs = songService.Search(keyword).ToList();
            gridSong.DataSource = songs;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gearhost.Song newSong = new gearhost.Song()
            {
                Id = 0,
                Title = txtTitle.Text.Trim(),
                Singer = txtSinger.Text.Trim(),
                Album = txtAlbum.Text.Trim(),
                Genre = txtGenre.Text.Trim(),
            };
            bool result = songService.AddNew(newSong);
            if (result)
            {
                List<gearhost.Song> songs = songService.GetAll().ToList();
                gridSong.DataSource = songs;
            }
            else
            {
                MessageBox.Show("Sorry Something Wrong");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            gearhost.Song newSong = new gearhost.Song()
            {
                Id = int.Parse(txtId.Text.Trim()),
                Title = txtTitle.Text.Trim(),
                Singer = txtSinger.Text.Trim(),
                Album = txtAlbum.Text.Trim(),
                Genre = txtGenre.Text.Trim(),
            };
            bool result = songService.Update(newSong);
            if (result)
            {
                List<gearhost.Song> songs = songService.GetAll().ToList();
                gridSong.DataSource = songs;
            }
            else
            {
                MessageBox.Show("Sorry Something Wrong");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure?", "COMFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int code = int.Parse(txtId.Text);
                bool result = songService.Delete(code);
                if (result)
                {
                    List<gearhost.Song> songs = songService.GetAll().ToList();
                    gridSong.DataSource = songs;
                }
                else
                {
                    MessageBox.Show("Sorry Something Wrong");
                }

            }
        }
    }
}
