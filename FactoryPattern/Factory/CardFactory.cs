using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public abstract class CardFactory
    {
        public abstract CreditCard GetCardObject();
    }
}
