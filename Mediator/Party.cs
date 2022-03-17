using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class Party
    {
        protected ISale _sale;
        protected Party(ISale sale)
        {
            _sale = sale;
        }
    }
}
