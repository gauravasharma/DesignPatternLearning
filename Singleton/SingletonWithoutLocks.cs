using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonWithoutLocks
    {
        private static readonly SingletonWithoutLocks _instance = new SingletonWithoutLocks();
        private SingletonWithoutLocks()
        {

        }
        static SingletonWithoutLocks()
        {

        }
        public static SingletonWithoutLocks Instance
        {
            get { 
                return _instance;
            }
        }
    }
}
