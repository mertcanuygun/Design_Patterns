using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Concrete
{
    public class Manager : Party
    {
        public Manager(ISale transfer) : base(transfer)
        {
        }
        public void Comission(int amount)
        {
            Console.WriteLine($"Manager {amount}$ comission received.");
            _sale.AlbumSales(this, amount);
        }
    }
}
