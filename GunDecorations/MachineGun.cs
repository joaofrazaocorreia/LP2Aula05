using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class MachineGun : Gun
    {
        public override int AmmoCapacity { get; }
        public override float NoiseLevel { get; }
        public override string Name { get; }

        public MachineGun()
        {
            AmmoCapacity = 100;
            NoiseLevel = 8f;
            Name = "Machine Gun";
        }
    }
}