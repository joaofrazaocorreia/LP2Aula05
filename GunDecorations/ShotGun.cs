using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class ShotGun : Gun
    {
        public override int AmmoCapacity { get; }
        public override float NoiseLevel { get; }

        public ShotGun()
        {
            AmmoCapacity = 45;
            NoiseLevel = 20f;
        }
    }
}