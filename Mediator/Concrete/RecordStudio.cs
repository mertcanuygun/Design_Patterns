using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Concrete
{
    public class RecordStudio : Party
    {
        public RecordStudio(ISale transfer) : base(transfer)
        {
        }
        public void RecordRevenue(int amount)
        {
            Console.WriteLine($"Record Studio: {amount}$ revenue received.");
        }
    }
}
