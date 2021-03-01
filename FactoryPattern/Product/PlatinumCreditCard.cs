using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class PlatinumCreditCard : CreditCard
    {
        private string _cardType;
        private int _creditLimit;

        public PlatinumCreditCard(int creditLimit)
        {
            _cardType = "Platinum";
            _creditLimit = creditLimit;
        }

        public override string CardType
        {
            get { return _cardType; }
        }

        public override int CreditLimit
        {
            get { return _creditLimit; }
            set { _creditLimit = value; }
        }

    }
}
