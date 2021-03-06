﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonNotThreadSafe
    {
        private static SingletonNotThreadSafe _instance = null;
        private SingletonNotThreadSafe()
        {

        }

        public static SingletonNotThreadSafe Instance
        {
            get { 
                if(_instance==null)
                {
                    _instance=new SingletonNotThreadSafe();
                }
                return _instance;
            }
        }
    }
}
