using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CardFactory factory = null;

            factory = new GoldCardFactory(50000);

            CreditCard card = factory.GetCardObject();

            Console.WriteLine(card.CardType);

            factory = new PlatinumCardFactory(50000);

            CreditCard card1 = factory.GetCardObject();

            Console.WriteLine(card1.CardType);

            Console.ReadLine();
        }
    }
}
