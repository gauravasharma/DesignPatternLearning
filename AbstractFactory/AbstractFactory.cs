using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AbstractFactory
    {
        static void Main(string[] args)
        {
            SBICardFactory sbifactory = new SBICardFactory();

            ClientFactory factory1 = new ClientFactory(sbifactory, "gold");
            Console.WriteLine("SBI");
            Console.WriteLine(factory1.GetCreditCardName()) ;
            Console.WriteLine(factory1.GetDebitCardName());

            factory1 = new ClientFactory(sbifactory, "platinum");
            Console.WriteLine(factory1.GetCreditCardName());
            Console.WriteLine(factory1.GetDebitCardName());
            Console.ReadLine();

            ICICICardFactory iciciFactory = new ICICICardFactory();

            ClientFactory factory2 = new ClientFactory(iciciFactory, "gold");
            Console.WriteLine("ICICI");
            Console.WriteLine(factory2.GetCreditCardName());
            Console.WriteLine(factory2.GetDebitCardName());

            factory2 = new ClientFactory(iciciFactory, "platinum");
            Console.WriteLine(factory2.GetCreditCardName());
            Console.WriteLine(factory2.GetDebitCardName());
            Console.ReadLine();


        }
    }
}
