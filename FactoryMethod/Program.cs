using FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicCreator creator = new MusicCreator();
            Music music;

            for (int trackno = 1; trackno < 13; trackno++)
            {
                music = creator.Playlist(trackno);
                Console.WriteLine($"Playing song is {music.Genre()}");
            }
        }
    }
}
