using Dependency_Injection.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LaMusica laMusica = new LaMusica(new RockPlaylist());

            Console.WriteLine(laMusica.Listen());
        }
    }
}
