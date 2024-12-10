namespace MusicSqlDatabase
{
    public partial class UpdatePlaylistForm : UpdateFrm
    {
        public MusicDAO dao;
        int id;

        string name;
        string description;

        public UpdatePlaylistForm(MusicDAO dao, int id, string name, string description)
        {
            InitializeComponent();
            this.dao = dao;
            this.update = false;
            this.id = id;

            this.name = name;
            this.playlistNameTextBox.Text = this.name;

            this.description = description;
            this.playlistDescriptionTextBox.Text = this.description;
        }

        private void CancelButtonClick(object sender, EventArgs e) => Close();

        private void AddPlaylistButtonClick(object sender, EventArgs e)
        {
            dao.UpdatePlaylist(id, name, description);
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
