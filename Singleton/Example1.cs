using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Example1
    {
        private Example1()
        {
        }

        public static Example1 _song1;

        public static Example1 GetSong()
        {
            if (_song1 == null)
            {
                _song1 = new Example1();
            }
            return _song1;
        }

        public string PlaySong()
        {
            return "playing.";
        }

        public string SongName_1 { get; set; }
        public string Artist_1 { get; set; }
    }
}
