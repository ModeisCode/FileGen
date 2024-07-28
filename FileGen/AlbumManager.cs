using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileGen
{
    public class AlbumManager
    {

        public string albumJsonFilesPath;
        public List<Album> albums;

        public AlbumManager(List<Album> albums)
        {
            albumJsonFilesPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Albums");
            this.albums = albums;
        }

        public void saveAsJson(AlbumData albumData)
        {
            var data = new
            {
                name = albumData.name,
                description = albumData.description,
                date = albumData.date.ToString(),
                isPrivate = albumData.isPrivate.ToString(),
                albumFolderPath = albumData.albumPath,
                albumBackgroundImagePath = albumData.albumBackgroundImagePath != null ? albumData.albumBackgroundImagePath : "null",
                albumPassword = albumData.password != null ? albumData.password : "null",
                isStarred = albumData.star.ToString(),
                albumStateText = albumData.albumState.ToString(),
            };

            try
            {

                try
                {
                    string filePath = Path.Combine(albumJsonFilesPath, (data.name + ".json"));
                    using (FileStream fs = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        string jsonData = JsonSerializer.Serialize(data);
                        byte[] encodedText = Encoding.UTF8.GetBytes(jsonData);
                        fs.Write(encodedText, 0, encodedText.Length);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void showAllAlbums(ListBox listBox) 
        {
            string klasorYolu = albumJsonFilesPath;

            try
            {
                // Belirtilen klasörde bulunan tüm dosyaları al
                string[] dosyalar = Directory.GetFiles(klasorYolu);

                // Dosyaları bir listbox'a ekle (örnek)
                listBox.Items.Clear();
                foreach (string dosya in dosyalar)
                {
                    listBox.Items.Add(dosya);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }


    }
}
