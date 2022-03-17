using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Concrete
{
    public class Album : Party
    {
        public Album(ISale sale) : base(sale)
        {
        }
        public void Sales(int amount)
        {
            Console.WriteLine($"{amount} Album Sold.");
            _sale.AlbumSales(this, amount);
        }
    }
}
