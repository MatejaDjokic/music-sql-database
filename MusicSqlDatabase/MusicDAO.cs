using System.Data;
using System.Data.OleDb;

namespace MusicSqlDatabase
{
    public delegate T DbDelegate<T>();

    public class MusicDAO
    {
        private string provider = "Microsoft.ACE.OLEDB.12.0";
        private string dataSource = "D:/programiranje/projects/MatejaDjokic/music-sql-database/MusicSqlDatabase/music.mdb";

        private OleDbConnection connection;

        public MusicDAO()
        {
            connection = new OleDbConnection($"Provider={provider};Data Source={dataSource}");
        }

        private Result<T> RunInDb<T>(DbDelegate<T> function)
        {
            if (connection != null)
            {
                connection.Open();
                T ret = function();
                connection.Close();
                return new Result<T>(ret);
            }
            return new Result<T>(err: "Connection is null!");
        }

        private DataTable RunQuery(params string[] queryLines)
        {
            string query = string.Join("\n", queryLines);
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public Result<DataTable> LoadSongs
            () => RunInDb(
                () => RunQuery("SELECT song_name as Ime, release_date as Godina, artist as Umetnik FROM songs")
            );

        public Result<DataTable> LoadPlaylists
            () => RunInDb(
                () => RunQuery("SELECT playlist_name as Ime, description as Opis FROM playlists")
            );

        public Result<DataTable> LoadSongsTable
            () => RunInDb(
                () => RunQuery(
                    "SELECT id, song_name, release_date, artist FROM songs"
                )
            );

        public Result<DataTable> LoadPlaylistsTable
            () => RunInDb(
                () => RunQuery("SELECT id, playlist_name, description FROM playlists")
            );

        private Result<DataTable> LoadPlaylistSongTable
            () => RunInDb(
                () => RunQuery("SELECT psid, song_id, playlist_id FROM playlist_song")
            );

        public Result<DataTable> LoadSongsByPlaylist
            (int playlistId) => RunInDb(
                () => RunQuery(
                        "SELECT song_name as Ime, release_date as Godina, artist as Umetnik",
                        "FROM (songs s",
                        "INNER JOIN playlist_song ps ON s.id = ps.song_id)",
                        "INNER JOIN playlists p ON ps.playlist_id = p.id",
                        $"WHERE p.id = {playlistId}"
                    )
                );

        public Result<DataTable> LoadSongsTableByPlaylist
            (int playlistId) => RunInDb(
                () => RunQuery(
                        "SELECT s.id, song_name, release_date, artist",
                        "FROM (songs s",
                        "INNER JOIN playlist_song ps ON s.id = ps.song_id)",
                        "INNER JOIN playlists p ON ps.playlist_id = p.id",
                        $"WHERE p.id = {playlistId}"
                    )
                );

        public Result<DataTable> LoadSongsByInterval
            (int start, int end) => RunInDb(
                () => RunQuery(
                        "SELECT song_name as Ime, release_date as Godina, artist as Umetnik FROM songs",
                        $"WHERE release_date >= {start} AND release_date <= {end};"
                    )
                );

        public void InsertNewPlaylist(string playlistName, string description)
        {
            DataTable playlistsTable = LoadPlaylistsTable().Unwrap();
            DataRow lastRow = playlistsTable.Rows[playlistsTable.Rows.Count - 1];
            int oldId = (int)lastRow[0];

            RunInDb(() => RunQuery(
                        "INSERT INTO playlists",
                        $"VALUES ({oldId + 1}, \"{playlistName}\", \"{description}\")"
            ));
        }

        public void DeletePLaylist
            (int id) => RunInDb(
                () => RunQuery(
                       "DELETE FROM playlists",
                        $"WHERE id = {id}"
                    )
                );

        public void UpdatePlaylist
            (int id, string newName, string newDescription) => RunInDb(
                () => RunQuery(
                    "UPDATE playlists",
                    $"SET playlist_name = \"{newName}\", description = \"{newDescription}\"",
                    $"WHERE id = {id}"
                    )
                );

        public void InsertNewSong(string songName, string songYear, string songArtist, int playlistId)
        {
            DataTable songsTable = LoadSongsTable().Unwrap();
            DataRow lastRow = songsTable.Rows[songsTable.Rows.Count - 1];
            int oldId = (int)lastRow[0];
            int songId = oldId + 1;

            RunInDb(() => RunQuery(
                    "INSERT INTO songs",
                    $"VALUES ({songId}, \"{songName}\", {songYear}, \"{songArtist}\")"
            ));

            if (playlistId != 1)
                InsertPlaylistSongConnection(songId, playlistId);
            InsertPlaylistSongConnection(songId, 1);
        }

        public void InsertPlaylistSongConnection(int songId, int playlistId)
        {
            DataTable playlistSongTable = LoadPlaylistSongTable().Unwrap();
            DataRow lastRow = playlistSongTable.Rows[playlistSongTable.Rows.Count - 1];
            int oldId = (int)lastRow[0];

            RunInDb(
                () => RunQuery(
                    "INSERT INTO playlist_song",
                    $"VALUES ({oldId + 1}, {songId}, {playlistId})"
                )
            );
        }

        public void DeleteSong(int songId)
        {
            RunInDb(() => RunQuery(
                "DELETE FROM songs",
                $"WHERE id = {songId}"
            ));
            RunInDb(() => RunQuery(
                "DELETE FROM playlist_song",
                $"WHERE song_id = {songId}"
            ));
        }

        public void UpdateSong
            (int id, string newName, string newYear, string newArtist) => RunInDb(
                () => RunQuery(
                    "UPDATE songs",
                    $"SET song_name = \"{newName}\", release_date = {newYear}, artist = \"{newArtist}\"",
                    $"WHERE id = {id}"
                )
            );

    }
}
