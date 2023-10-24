using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public abstract class Gun
    {
        public abstract int AmmoCapacity { get; }
        public abstract float NoiseLevel { get; }
        public abstract string Name { get; }

        public void Fire()
        {
            Console.WriteLine("This " + Name + " has " + AmmoCapacity +
                            " Ammo Capacity and a Noise Level of " + NoiseLevel);
        }
    }
}