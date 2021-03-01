using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface ICardFactory
    {
        IDebitCard GetDebitCard(string type);
        ICreditCard GetCreditCard(string type);
    }
}
