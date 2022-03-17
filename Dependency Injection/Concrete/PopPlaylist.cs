using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection.Concrete
{
    public class PopPlaylist : IPlaylist
    {
        public string Pause()
        {
            return "Pausing Break of Dawn by Michael Jackson";
        }

        public string Play()
        {
            return "Playing Break of Dawn by Michael Jackson";
        }
    }
}
