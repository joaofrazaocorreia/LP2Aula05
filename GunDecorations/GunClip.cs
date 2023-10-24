using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class GunClip : GunDecorator
    {
        public override int AmmoCapacity { get; }

        public GunClip(Gun gun) : base(gun)
        {
            AmmoCapacity = gun.AmmoCapacity + 40;
        }
    }
}