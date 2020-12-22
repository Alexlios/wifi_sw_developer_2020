using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIFI.PlaylistEditor.Repositories;
using WIFI.PlaylistEditor.Types;

namespace WIFI.PlaylistEditor.Factories
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly IPlaylistItemFactory _playlistItemFactory;

        public RepositoryFactory(IPlaylistItemFactory playlistItemFactory)
        {
            _playlistItemFactory = playlistItemFactory;
        }

        public IEnumerable<IFileIdentifier> KnownTypes
        {
            get
            {
                return new IFileIdentifier[]
                {
                    new M3uRepository(_playlistItemFactory)
                };
            }
        }

        public IRepository Create(string playlistPath)
        {
            IRepository repository = null;

            if (string.IsNullOrWhiteSpace(playlistPath))
            {
                return repository;
            }

            var extension = Path.GetExtension(playlistPath);

            switch (extension)
            {
                case ".m3u":
                    repository = new M3uRepository(_playlistItemFactory);
                    //repository.Load(playlistPath);
                    break;

                default:
                    repository = null;
                    break;
            }

            return repository;
        }
    }
}
