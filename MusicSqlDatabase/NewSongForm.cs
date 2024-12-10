namespace MusicSqlDatabase
{
    public partial class NewSongForm : UpdateFrm
    {
        public MusicDAO dao;
        int playlistId;

        string name;
        string year;
        string artist;

        public NewSongForm(MusicDAO dao, int playlistId)
        {
            InitializeComponent();

            this.dao = dao;
            this.update = false;
            this.playlistId = playlistId;

            this.name = string.Empty;
            this.year = string.Empty;
            this.artist = string.Empty;
        }

        private void CancelButtonClick(object sender, EventArgs e) => Close();

        private void AddSongButtonClick(object sender, EventArgs e)
        {
            dao.InsertNewSong(name, year, artist, playlistId);
            update = true;
            Close();
        }

        private void SongNameTextBoxTextChanged(object sender, EventArgs e)
        {
            TextBox nameTextBox = (TextBox)sender;
            name = nameTextBox.Text.Trim();
        }

        private void SongYearTextBoxTextChanged(object sender, EventArgs e)
        {
            TextBox yearTextBox = (TextBox)sender;
            year = yearTextBox.Text.Trim();
        }

        private void SongArtirstTextBoxTextChanged(object sender, EventArgs e)
        {
            TextBox artistTexBox = (TextBox)sender;
            artist = artistTexBox.Text.Trim();
        }
    }
}
