using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Concrete
{
    public class Artist : Party
    {
        public Artist(ISale transfer) : base(transfer)
        {
        }

        public void ArtistRevenue(int amount)
        {
            Console.WriteLine($"Artist: {amount}$ received.");
            _sale.AlbumSales(this, amount);
        }
    }
}
