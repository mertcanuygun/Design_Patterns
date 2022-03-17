using Mediator.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class SaleMediator : ISale
    {
        Artist artist;
        RecordStudio recordStudio;
        Manager manager;
        Album album;

        public Album Album { set => album = value; }
        public Artist Artist { set => artist = value; }
        public RecordStudio RecordStudio { set => recordStudio = value; }
        public Manager Manager { set => manager = value; }

        public void AlbumSales(Party party, int amount)
        {
            if (party is Album && amount > 100000)
            {
                artist.ArtistRevenue(amount * 50 / 100);
                manager.Comission(amount * 30 / 100);
                recordStudio.RecordRevenue(amount * 20 / 100);
            }
            else if (party is Album && amount <= 100000)
            {
                artist.ArtistRevenue(amount * 40 / 100);
                manager.Comission(amount * 35 / 100);
                recordStudio.RecordRevenue(amount * 25 / 100);
            }

        }
    }
}
