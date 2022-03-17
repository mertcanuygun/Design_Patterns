using Decorator.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMusic music = new Music();

            Music.Play("Without Extension: ", music);
            Music.Play("New Version: ", new Acapella(music));
            Music.Play("Another new version: ", new Unplugged(music));
        }
    }
}
