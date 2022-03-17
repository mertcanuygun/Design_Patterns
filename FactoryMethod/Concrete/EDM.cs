using FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public class EDM : Music
    {
        public override Enum Genre()
        {
            return Enum.EDM;
        }
    }
}
