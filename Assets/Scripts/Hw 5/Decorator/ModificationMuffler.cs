using UnityEngine;


namespace Asteroid
{
    internal sealed class ModificationMuffler : ModificationWeapon
    {
        private readonly AudioSource _audioSource;
        private readonly IMuffer _muffer;
        private readonly Vector3 _mufferPosition;
        private Weapon _weapon;

       public ModificationMuffler(AudioSource audioSource, IMuffer muffer, Vector3 mufferPosition)
        {
            _audioSource = audioSource;
            _muffer = muffer;
            _mufferPosition = mufferPosition;
        }

        protected override Weapon AddModification(Weapon weapon)
        {
            _weapon = weapon;
            _muffer.MufflerInstance.SetActive(true);
            
            _audioSource.volume = _muffer.VolumeFireOnMuffler;
            weapon.SetAudioClip(_muffer.AudioClipMuffer);
            weapon.SetBarrelPosition(_muffer.BarrelPositionMuffer);
            return weapon;
        }

    }
}
