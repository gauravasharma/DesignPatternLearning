using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SBICardFactory : ICardFactory
    {
        public ICreditCard GetCreditCard(string type)
        {
            switch (type)
            {
                case "gold":
                    return new GoldCreditCard();
                case "platinum":
                    return new PlatinumCreditCard();
            }

            return null;
        }

        public IDebitCard GetDebitCard(string type)
        {
            switch (type)
            {
                case "gold":
                    return new GoldDebitCard();
                case "platinum":
                    return new PlatinumDebitCard();
            }
            return null;
        }
    }
}
