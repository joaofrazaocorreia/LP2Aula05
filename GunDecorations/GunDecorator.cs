using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public abstract class GunDecorator : Gun
    {
        protected Gun baseGun;
        public override int AmmoCapacity { get; }
        public override float NoiseLevel { get; }
        
        public GunDecorator(Gun gun)
        {
            baseGun = gun;
            AmmoCapacity = gun.AmmoCapacity;
            NoiseLevel = gun.NoiseLevel;
        }
    }
}