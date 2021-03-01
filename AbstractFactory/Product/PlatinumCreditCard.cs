using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PlatinumCreditCard :ICreditCard
    {
        public string Name()
        {
            return "Platinum credit card";
        }
    }
}
