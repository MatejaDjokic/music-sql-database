namespace MusicSqlDatabase
{
    public partial class NewPlaylistForm : UpdateFrm
    {
        public MusicDAO dao;

        string name;
        string description;

        public NewPlaylistForm(MusicDAO dao)
        {
            InitializeComponent();

            this.dao = dao;
            this.update = false;

            this.name = string.Empty;
            this.description = string.Empty;
        }

        private void CancelButtonClick(object sender, EventArgs e) => Close();

        private void AddPlaylistButtonClick(object sender, EventArgs e)
        {
            dao.InsertNewPlaylist(name, description);
            update = true;
            Close();
        }

        private void PlaylistNameTextBoxTextChanged(object sender, EventArgs e)
        {
            TextBox nameTextBox = (TextBox)sender;
            name = nameTextBox.Text.Trim();
        }

        private void PlaylistDescriptionTextBoxTextChanged(object sender, EventArgs e)
        {
            TextBox descriptionTextBox = (TextBox)sender;
            description = descriptionTextBox.Text.Trim();
        }
    }
}
