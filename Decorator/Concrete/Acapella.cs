using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Concrete
{
    public class Acapella : IMusic
    {
        private IMusic _acapella;

        public Acapella(IMusic music)
        {
            _acapella = music;
        }

        public string Extension()
        {
            return $"{_acapella.Extension()} acapella version.";
        }
    }
}
