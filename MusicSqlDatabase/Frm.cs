using System.Data;


namespace MusicSqlDatabase
{
    public partial class Frm : Form
    {
        public delegate bool EmptyMethod();

        MusicDAO dao;
        int playlistIdx;
        int songIdx;

        public Frm()
        {
            InitializeComponent();

            dao = new MusicDAO();
            playlistIdx = 0;

            Initialize();
        }

        public void Initialize()
        {
            UpdatePlaylists();
            UpdateSongs(1);
        }

        public void UpdatePlaylists(EmptyMethod? function = null)
        {
            bool update = true;
            if (function != null)
                update = function();

            if (update)
                playListsTable.DataSource = dao.LoadPlaylists().Unwrap();
        }

        public void UpdateSongs(int playlistId, EmptyMethod? function = null)
        {
            bool update = true;
            if (function != null)
                update = function();

            if (update)
                songsTable.DataSource = dao.LoadSongsByPlaylist(playlistId).Unwrap();
        }

        private void PlayListsTableCellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable playlistTable = dao.LoadPlaylistsTable().Unwrap();
            int rowCount = playListsTable.Rows.Count;
            int x = e.ColumnIndex;
            playlistIdx = e.RowIndex;
            songIdx = 0;

            if (playlistIdx > -1 && playlistIdx < rowCount - 1)
            {
                DataRow record = playlistTable.Rows[playlistIdx];
                int playlistId = (int)(record[0] ?? 0);
                songsTable.DataSource = dao.LoadSongsByPlaylist(playlistId).Unwrap();
            }
        }

        private void SongsTableCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int playlistId = (int)dao.LoadPlaylistsTable().Unwrap().Rows[playlistIdx][0];
            DataTable songTable = dao.LoadSongsTableByPlaylist(playlistId).Unwrap();

            if (e.RowIndex > -1 && e.RowIndex < songTable.Rows.Count)
                songIdx = e.RowIndex;
        }

        private void AddPlaylistButtonClick
            (object sender, EventArgs e) => UpdatePlaylists(
                () =>
                {
                    NewPlaylistForm npf = new NewPlaylistForm(dao);
                    npf.ShowDialog();
                    return npf.update;
                }
        );

        private void DeletePlaylistButtonClick
            (object sender, EventArgs e) => UpdatePlaylists(
                () =>
                {
                    DataRow record = dao.LoadPlaylistsTable().Unwrap().Rows[playlistIdx];
                    int id = (int)record[0];

                    if (id == 1)
                        MessageBox.Show(
                            "Ne mozete da izbrisete listu svih pesama!",
                            "Greska!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    else
                    {
                        DialogResult result = MessageBox.Show(
                            "Da li ste sigurni da zelite da izbrisete plejlistu?",
                            "Izbrisi Plejlistu",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (result == DialogResult.Yes)
                        {
                            dao.DeletePLaylist(id);
                            return true;
                        }
                    }
                    return false;
                }
        );

        private void EditPlaylistButtonClick
            (object sender, EventArgs e) => UpdatePlaylists(
                () =>
                {
                    DataTable playlistTable = dao.LoadPlaylistsTable().Unwrap();
                    DataRow record = playlistTable.Rows[playlistIdx];

                    int id = (int)record[0];
                    string name = (string)record[1];
                    string description = (string)record[2];
                    UpdatePlaylistForm upf = new UpdatePlaylistForm(dao, id, name, description);
                    upf.ShowDialog();
                    return upf.update;
                }
            );

        private void AddSongButtonClick(object sender, EventArgs e)
        {
            int playlistId = (int)dao.LoadPlaylistsTable().Unwrap().Rows[playlistIdx][0];
            UpdateSongs(
                playlistId,
                () =>
                {
                    NewSongForm nsf = new NewSongForm(dao, playlistId);
                    nsf.ShowDialog();
                    return nsf.update;
                }
            );
        }

        private void DeleteSongButtonClick(object sender, EventArgs e)
        {
            int playlistId = (int)dao.LoadPlaylistsTable().Unwrap().Rows[playlistIdx][0];
            UpdateSongs(
                playlistId,
                () =>
                {
                    DialogResult result = MessageBox.Show(
                      "Da li ste sigurni da zelite da izbrisete pesmu?",
                      "Izbrisi Pesmu",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        DataRow record = dao.LoadSongsTableByPlaylist(playlistId).Unwrap().Rows[songIdx];
                        int id = (int)record[0];
                        dao.DeleteSong(id);
                        return true;
                    }
                    return false;
                }
            );
        }

        private void EditSongButtonClick(object sender, EventArgs e)
        {
            UpdateSongs(
                (int)dao.LoadPlaylistsTable().Unwrap().Rows[playlistIdx][0],
                () =>
                {
                    int playlistId = (int)dao.LoadPlaylistsTable().Unwrap().Rows[playlistIdx][0];
                    DataTable songsTable = dao.LoadSongsTableByPlaylist(playlistId).Unwrap();

                    DataRow record = songsTable.Rows[songIdx];

                    int id = (int)record[0];
                    string name = (string)record[1];
                    string year = ((int)record[2]).ToString();
                    string artist = (string)record[3];

                    UpdateSongForm usf = new UpdateSongForm(dao, id, name, year, artist);
                    usf.ShowDialog();
                    return usf.update;
                }
            );
        }
    }
}
