using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Concrete
{
    public class Unplugged : IMusic
    {

        private IMusic _unplugged;

        public Unplugged(IMusic music)
        {
            _unplugged = music;
        }

        public string Extension()
        {
            return $"{_unplugged.Extension()} unplugged version.";
        }
    }
}
