using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class GunClip : GunDecorator
    {
        public override int AmmoCapacity { get; }
        public override string Name { get; }

        public GunClip(Gun gun) : base(gun)
        {
            AmmoCapacity = gun.AmmoCapacity + 40;
            Name = gun.Name + " with an Ammo Clip";
        }
    }
}