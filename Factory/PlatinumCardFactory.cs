using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class PlatinumCardFactory : CardFactory
    {
        int _creditLimit;

        public PlatinumCardFactory(int creditLimit)
        {
            _creditLimit = creditLimit;
        }
        public override CreditCard GetCardObject()
        {
            return new PlatinumCreditCard(_creditLimit);
        }
    }
}
