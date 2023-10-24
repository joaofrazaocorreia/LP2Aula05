using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class GunSilencer : GunDecorator
    {
        public override float NoiseLevel { get; }

        public GunSilencer(Gun gun) : base(gun)
        {
            NoiseLevel = gun.NoiseLevel * 0.2f;
        }
    }
}