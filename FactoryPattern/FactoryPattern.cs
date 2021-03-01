using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class FactoryPattern
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = null;
            factory = new CardFactory();
            CreditCard obj1=factory.GetCardObject(1);
            Console.WriteLine(obj1.CardType);
            CreditCard obj2 = factory.GetCardObject(2);
            Console.WriteLine(obj2.CardType);
            Console.ReadLine();
        }
    }
}
