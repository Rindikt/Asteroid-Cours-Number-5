using UnityEngine;


namespace Asteroid
{
    internal class BadaBum : IWeaponHw
    {
        public IAmmuntion _bulet { get; }

        public AudioClip _audioClip { get; }

        public float VolumeFireOnMuffler { get; }

        //public Transform BarrelPosition { get; }
        public BadaBum(IAmmuntion bulet, AudioClip audioClip, float volumeFireOnMuffler)
        {
            _bulet = bulet;
            _audioClip = audioClip;
            VolumeFireOnMuffler = volumeFireOnMuffler;
        }
    }
}
