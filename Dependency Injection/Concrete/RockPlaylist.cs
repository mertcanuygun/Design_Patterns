using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection.Concrete
{
    public class RockPlaylist : IPlaylist
    {
        public string Pause()
        {
            return "Pausing Need You Around by Smoking Popes";
        }

        public string Play()
        {
            return "Playing Need You Around by Smoking Popes";
        }
    }
}
