using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Music : IMusic
    {
        public string Extension()
        {
            return $"Thriller by Michael Jackson";
        }

        public static void Play(string message, IMusic bilesen)
        {
            Console.WriteLine(message + bilesen.Extension());
        }
    }
}
