using Playlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class M3URepository : IRepository
    {
        private string _extension;
        private string _description;

        public string Extension { get => _extension; }

        public string Description { get => _description; }

        public IPlaylist Load(string filePath)
        {
            throw new NotImplementedException();
        }

        public void Save(string filePath, IPlaylist playlist)
        {
            throw new NotImplementedException();
        }
    }
}
