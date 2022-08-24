using UnityEngine;

namespace Asteroid
{
    public sealed class DefaultWeapon : IWeapon
    {
        private Transform _weapon;
        private GameObject _bullet;
        private float _force = 20.0f;
        private ObjectPool pool;
        public float demage => 2;

        public DefaultWeapon(Transform weapon, GameObject bulet)
        {
            _weapon = weapon;
            _bullet = bulet;

            pool = new ObjectPool(_bullet);
        }


        public void Attack()
        {
               var bul = CreateBull();
               bul.AddForce(_weapon.transform.up * _force,ForceMode2D.Impulse);

        }
        private void SetBuletPos(GameObject bullet)
        {
            bullet.transform.position = _weapon.position;
            bullet.transform.rotation = _weapon.rotation;
        }     
        public Rigidbody2D CreateBull()
        {
            var bullet = pool.Pop();
            SetBuletPos(bullet);
            if (!bullet.TryGetComponent<Bullet>(out Bullet _bullet))
            {
                var s = bullet.AddComponent<Bullet>();
                s.demage = this.demage;
                s.Hit += () => pool.Push(bullet);
            }


            var bul = bullet.GetComponent<Rigidbody2D>();
            return bul;
        }
    }
}