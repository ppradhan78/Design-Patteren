using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubletonDesignPattern
{
    
    public sealed class SealedDoubleton
    {
        private static SealedDoubleton _doubleton = null;
        private static readonly object doubletonLock = new object();
        private static int index = 0;
        public static int count = 0;

        private SealedDoubleton() { }

        public static SealedDoubleton GetInstance()
        {
            lock (doubletonLock)
            {
                if (index < 2)
                {
                    _doubleton = new SealedDoubleton();
                    index++;
                    count++;
                }
            }
            return _doubleton;
        }

    }
}
