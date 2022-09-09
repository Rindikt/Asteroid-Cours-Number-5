using UnityEngine;


namespace Asteroid
{
    internal class ModificatorBadaBum : ModificationWeapon
    {
        private readonly AudioSource _audioSource;
        private readonly IWeaponHw _weaponHw;

        public ModificatorBadaBum(AudioSource audioSource, IWeaponHw weaponHw)
        {
            _audioSource = audioSource;
            _weaponHw = weaponHw;
        }

        protected override Weapon AddModification(Weapon weapon)
        {
            _audioSource.volume = _weaponHw.VolumeFireOnMuffler;
            weapon.SetAudioClip(_weaponHw._audioClip);
            weapon.SetBullet(_weaponHw._bulet);
            return weapon;
        }
    }
}
