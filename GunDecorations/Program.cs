using System;

namespace GunDecorations
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun myMachineGun = new MachineGun();
            Gun myShotGun = new ShotGun();

            myMachineGun.Fire();
            myShotGun.Fire();

            Gun myMachineGunWithSilencer = new GunSilencer(myMachineGun);
            myMachineGunWithSilencer.Fire();

            Gun myShotGunWithClip = new GunClip(myShotGun);
            Gun myShotGunWithClipAndSilencer = new GunSilencer(myShotGunWithClip);

            myShotGunWithClipAndSilencer.Fire();
        }
    }
}
