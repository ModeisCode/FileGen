namespace FileGen
{
    public partial class Form1 : Form
    {

        public AlbumManager albumManager;

        private List<Album> albums = new List<Album>();


        private static AlbumGenerator albumGenerator;

        public Form1()
        {
            InitializeComponent();
            albumManager = new AlbumManager(albums);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addNewAlbumBtn_Click(object sender, EventArgs e)
        {
            albumGenerator = new AlbumGenerator(albumManager);
            albumGenerator.Show();
        }

        private void refreshAlbumsBtn_Click(object sender, EventArgs e)
        {
            albumManager.showAllAlbums(albumListBox);
        }
    }
}
