using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public class LaMusica
    {
        private IPlaylist _playlist;

        public LaMusica(IPlaylist playlist)
        {
            this._playlist = playlist;
        }

        public string Listen()
        {
            return _playlist.Play();
        }
    }
}
