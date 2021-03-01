using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class GoldCardFactory : CardFactory
    {
        int _creditLimit;
        public GoldCardFactory(int creditLimit)
        {
            _creditLimit = creditLimit;
        }
        public override CreditCard GetCardObject()
        {
            return new GoldCreditCard(_creditLimit);
        }
    }
}
