using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasOOPExample
{
    class Television : IElectronicDevice
    {

        public int Volume { get; set; }

        void IElectronicDevice.SwitchOff()
        {
            Console.WriteLine("The TV has been switched off");
        }

        void IElectronicDevice.SwitchOn()
        {
            Console.WriteLine("The TV has been switched on");
        }

        void IElectronicDevice.VolumeDecrease()
        {
            if (Volume != 0 )
            {
                Volume--;
                Console.WriteLine($"TV's volume is at {0}.", Volume);
            } else
                Console.WriteLine($"TV's volume is at MIN volume.");
        }

        void IElectronicDevice.VolumeIncrease()
        {
            if (Volume < 100)
            {
                Volume++;
                Console.WriteLine($"TV's volume is at {0}.", Volume);
            } else
                Console.WriteLine($"TV's volume is at MAX volume.");
        }
    }
}
