using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example1 with static method

            Example1 song_1 = Example1.GetSong();
            song_1.SongName_1 = "Lake Shore Drive";
            song_1.Artist_1 = "Aliotaa Haynes Jeremiah";

            Console.WriteLine($"{song_1.SongName_1} by {song_1.Artist_1} is {song_1.PlaySong()}");

            #endregion

            #region Example2 with static property

            Example2.Song2.SongName_2 = "Africa";
            Example2.Song2.Artist_2 = "TOTO";

            Console.WriteLine($"{Example2.Song2.SongName_2} by {Example2.Song2.Artist_2} is {Example2.Song2.PlaySong()}");

            #endregion

            //I created 2 different objects with Example2 class. To be able to prove that the both objects are the same.
            Example2 object1 = Example2.Song2;
            Example2 object2 = Example2.Song2;

            //Calling address info for the created objects to see they are infact the same.
            Console.WriteLine(object1.GetHashCode());
            Console.WriteLine(object2.GetHashCode());
        }
    }
}
