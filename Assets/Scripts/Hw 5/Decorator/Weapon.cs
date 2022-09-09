using UnityEngine;
using Object = UnityEngine.Object;

namespace Asteroid
{
    internal class Weapon : IFire
    {
        private Transform _barrelPosition;
        private IAmmuntion _bullet;
        private float _force;
        private AudioClip _audioClip;
        private readonly AudioSource _audioSource;

        public Weapon(Transform barrelPosition, IAmmuntion bullet, float force, AudioClip audioClip, AudioSource audioSource)
        {
            _barrelPosition = barrelPosition;
            _bullet = bullet;
            _force = force;
            _audioClip = audioClip;
            _audioSource = audioSource;
        }

        public void SetBarrelPosition(Transform barrelPosition)
        {
            _barrelPosition = barrelPosition;
        }

        public void SetBullet(IAmmuntion bullet)
        {
            _bullet = bullet;
        }
        public void SetForce(float force)
        {
            _force = force;
        }

        public void SetAudioClip(AudioClip audioClip)
        {
            _audioClip = audioClip;
        }


        public void Fire()
        {
            var bullet = Object.Instantiate(_bullet.BulletInstance,_barrelPosition.position,_barrelPosition.rotation);
            bullet.AddForce(_barrelPosition.up * _force,ForceMode2D.Impulse);
            Object.Destroy(bullet, _bullet.TimeToDestroy);
            _audioSource.PlayOneShot(_audioClip);
        }
    }
}
