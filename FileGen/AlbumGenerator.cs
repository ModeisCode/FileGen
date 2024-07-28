using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileGen
{
    public partial class AlbumGenerator : Form
    {

        private List<Album> albums;
        private AlbumDataValidator validator = new AlbumDataValidator();
        private AlbumManager albumManager;

        public AlbumGenerator(AlbumManager albumManager)
        {
            InitializeComponent();
            this.albums = albumManager.albums;
            this.albumManager = albumManager;
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {

            AlbumData data = new AlbumData();
            try
            {

                if (!validator.isValidText(albumDescription.Text).isValidText(albumFolderPath.Text).isValidText(albumTextBox.Text).isValid)
                {
                    MessageBox.Show("Ensure the all inputs!");
                    return;
                }

                data.date = albumDate.Value;
                data.description = albumDescription.Text;
                data.star = addStarCB.Checked;
                data.name = albumTextBox.Text;
                data.albumPath = albumFolderPath.Text;
                data.isPrivate = isPrivateCB.Checked;
                data.albumState = AlbumState.SelectedText;
                data.albumBackgroundImagePath = albumBackgroundImagePath.Text;

                if (data.isPrivate)
                {
                    data.password = passwordTextBox.Text;
                    if (!validator.IsValidPassowrd(data.password))
                    {
                        return;
                    }
                }

                Album newAlbum = new Album(data);

                albums.Add(newAlbum);
         
                albumManager.saveAsJson(data);

                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ensure the all inputs!");
            }

        }

        private void AlbumGenerator_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                albumBackgroundImagePath.Text = openFileDialog1.FileName;
                albumIcon.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void AlbumPathSelectBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                albumFolderPath.Text = folderBrowserDialog.SelectedPath;
            }
        }


    }
}
