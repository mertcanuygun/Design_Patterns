using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Example2
    {
        private Example2()
        {
        }

        private static Example2 _song2;

        public static Example2 Song2
        {
            get
            {
                if (_song2 == null)
                {
                    _song2 = new Example2();
                }
                return _song2;
            }
        }

        public string PlaySong()
        {
            return "playing.";
        }

        public string SongName_2 { get; set; }
        public string Artist_2 { get; set; }
    }
}
