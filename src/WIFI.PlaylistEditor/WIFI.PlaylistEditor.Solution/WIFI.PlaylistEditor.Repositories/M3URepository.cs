using PlaylistsNET.Content;
using PlaylistsNET.Models;
using System;
using System.Collections.Generic;
using System.IO;
using WIFI.PlaylistEditor.Types;

namespace WIFI.PlaylistEditor.Repositories
{
    public class M3uRepository : IRepository
    {
        private readonly IPlaylistItemFactory _playlistItemFactory;

        public M3uRepository(IPlaylistItemFactory playlistItemFactory)
        {
            _playlistItemFactory = playlistItemFactory;
        }

        #region Properties

        public string Extension { get => ".m3u"; }

        public string Description { get => "m3u Playlist file"; }

        #endregion

        #region PublicMethods

        public IPlaylist Load(string filePath)
        {
            IPlaylist playlist = null;
            M3uPlaylist m3uPlaylistBase = null;

            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                return null;
            }

            using (StreamReader sr = new StreamReader(filePath))
            {
                M3uContent content = new M3uContent();
                m3uPlaylistBase = content.GetFromStream(sr.BaseStream);
            }

            m3uPlaylistBase.Path = filePath;

            playlist = MapToDomain(m3uPlaylistBase);

            return playlist;
        }

        public void Save(string filePath, IPlaylist playlist)
        {
            M3uPlaylist m3uPlaylist = MapToEntity(playlist);

            M3uContent content = new M3uContent();
            string text = content.ToText(m3uPlaylist);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(text);
            }
        }

        #endregion

        #region PrivateMethods

        private M3uPlaylist MapToEntity(IPlaylist playlist)
        {
            M3uPlaylist m3UPlaylist = new M3uPlaylist();
            m3UPlaylist.IsExtended = true;

            m3UPlaylist.Comments.Add($"PLAYLIST-Author:{playlist.Author}");
            m3UPlaylist.Comments.Add($"PLAYLIST-Title:{playlist.Name}");
            m3UPlaylist.Comments.Add($"PLAYLIST-CreatedAt:{playlist.CreatedAt}");

            foreach (var item in playlist.Items)
            {
                var entry = new M3uPlaylistEntry()
                {
                    Duration = item.Duration,
                    Path = item.Path,
                    Title = item.Title,
                    Comments = new List<string>()
                };

                m3UPlaylist.PlaylistEntries.Add(entry);
            }

            return m3UPlaylist;
        }

        private IPlaylist MapToDomain(M3uPlaylist m3uPlaylistBase)
        {
            IPlaylist playlist = null;

            var commentList = ExtractAllComments(m3uPlaylistBase.PlaylistEntries);

            var author = GetValueFromComment("PLAYLIST-Author", commentList, "NoName");
            var title = GetValueFromComment("PLAYLIST-Title", commentList, Path.GetFileNameWithoutExtension(m3uPlaylistBase.Path));
            var createdAt = GetValueFromComment("PLAYLIST-CreatedAt", commentList, File.GetCreationTime(m3uPlaylistBase.Path).ToShortDateString());

            List<string> paths = m3uPlaylistBase.GetTracksPaths();

            playlist = new Playlist(title, author, DateTime.Parse(createdAt));
            foreach (var itemPath in paths)
            {
                var playlistItem = _playlistItemFactory.Create(itemPath);
                if (playlistItem != null)
                {
                    playlist.Add(playlistItem);
                }
            }

            return playlist;
        }

        private string GetValueFromComment(string key, IEnumerable<string> commentList, string defaultValue)
        {
            foreach (var comment in commentList)
            {
                if (comment.StartsWith(key))
                {
                    var parts = comment.Split(':');
                    if (parts.Length == 2)
                    {
                        return parts[1].Trim();
                    }
                }
            }

            return defaultValue;
        }

        private IEnumerable<string> ExtractAllComments(IEnumerable<M3uPlaylistEntry> playlistEntries)
        {
            List<string> commentList = new List<string>();

            foreach (var entry in playlistEntries)
            {
                if (entry.Comments != null && entry.Comments.Count > 0)
                {
                    commentList.AddRange(entry.Comments);
                }
            }

            return commentList;
        }

        #endregion
    }
}
