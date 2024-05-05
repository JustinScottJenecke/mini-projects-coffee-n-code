using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasOOPExample
{
    interface IElectronicDevice
    {
        void SwitchOn();
        void SwitchOff();

        void VolumeDecrease();
        void VolumeIncrease();
    }
}
