using DesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class CardFactory :AbstractFactory
    {
        public override CreditCard GetCardObject(int id)
        {
            switch(id)
            {
                case 1:
                   return new GoldCreditCard(5000);
                case 2:
                    return new PlatinumCreditCard(10000);
            }

            return null;
        }
    }
}
