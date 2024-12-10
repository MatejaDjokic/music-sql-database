namespace MusicSqlDatabase
{
    public partial class UpdateSongForm : UpdateFrm
    {
        public MusicDAO dao;
        int id;

        string name;
        string year;
        string artist;

        public UpdateSongForm(MusicDAO dao, int id, string name, string year, string artist)
        {
            InitializeComponent();

            this.dao = dao;
            base.update = false;
            this.id = id;

            this.name = name;
            this.songNameTextBox.Text = this.name;

            this.year = year;
            this.songYearTextBox.Text = this.year;


            this.artist = artist;
            this.artistTextBox.Text = this.artist;
        }

        private void CancelButtonClick(object sender, EventArgs e) => Close();

        private void AddSongButtonClick(object sender, EventArgs e)
        {
            dao.UpdateSong(id, name, year, artist);
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
