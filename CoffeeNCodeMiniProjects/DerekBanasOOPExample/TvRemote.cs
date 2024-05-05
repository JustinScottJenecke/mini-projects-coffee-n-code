using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasOOPExample
{
    class TvRemote
    {
        public static IElectronicDevice GetDevice() 
        {
            return new Television();
        }
    }
}
