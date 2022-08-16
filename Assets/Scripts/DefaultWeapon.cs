using UnityEngine;

namespace Asteroid
{
    public sealed class DefaultWeapon : MonoBehaviour, IWeapon
    {
        private Transform _weapon;
        private Rigidbody2D _bulet;
        private float _force = 20.0f;
        public DefaultWeapon(Transform weapon, Rigidbody2D bulet)
        {
            _weapon = weapon;
            _bulet = bulet;
            _bulet.GetComponent<Rigidbody2D>();

        }

        public float Demage { get; protected set; }

        public void Attack()
        {
            if (Input.GetButtonDown(MauseButtonManager.LEFT_MOUSE_BUTTON))
            {
                var bulet = Object.Instantiate(_bulet, _weapon.position,_weapon.rotation);

                //bulet.transform.Translate(_weapon.transform.up * _force,Space.Self);
                bulet.AddForce(_weapon.transform.up * _force,ForceMode2D.Impulse);

            }
        }
    }
}