using FactoryMethod.Abstract;
using FactoryMethod.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class MusicCreator
    {
        public Music Playlist(int trackNo)
        {
            if (trackNo > 0 && trackNo <= 5)
            {
                return new Rock();
            }
            else if (trackNo > 4 && trackNo <= 9)
            {
                return new Pop();
            }
            else
            {
                return new EDM();
            }
        }
    }
}
