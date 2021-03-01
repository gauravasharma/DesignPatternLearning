using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ClientFactory
    {
        ICreditCard creditCard;
        IDebitCard debitCard;
        string type;
        public ClientFactory(ICardFactory factory, string type)
        {
            creditCard = factory.GetCreditCard(type);
            debitCard = factory.GetDebitCard(type);
        }
        public string GetDebitCardName()
        {
            return debitCard.Name();
        }
        public string GetCreditCardName()
        {
            return creditCard.Name();
        }
    }
}
