using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace Asteroid
{
    internal class EnemyShip : Enemy
    {
        event Action Death = delegate () { };
        private Transform _player;
        public Transform _weapon;
        private Rigidbody2D _bullet;
        private Health _health;
        private float _stopDistance = 5;
        private float force = 10.0f;
        private float reload = 0;
        private void Awake()
        {
            _player = FindObjectOfType<Player>().transform;
            _body = GetComponent<Rigidbody2D>();
            _bullet = Resources.Load<Rigidbody2D>("Bullet/BulletEnemy");
            _healPoint = 15;
            _health = new Health(_healPoint);

        }
        private void Update()
        {
            Move();
        }
        protected override void Move()
        {
            var distance = (transform.position - _player.position).magnitude;
            Rotation(_player.transform.position);
            if (distance > _stopDistance)
            {      
                transform.position = Vector2.MoveTowards(transform.position,_player.position, 0.02f);
            }
            else
            {
                if (reload >0)
                {
                    reload -= 1 * Time.deltaTime;
                }
                else
                {
                Attack();
                    reload = 7;
                }
            }
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.TryGetComponent<Bullet>(out Bullet bullet))
            {
                _healPoint = _health.GetDamage(bullet.demage);
                if (_healPoint <= 0)
                {
                    Destroy(gameObject);
                    Death.Invoke();
                }
            }
        }
        
        private void Attack()
        {
            //var bulet = Object.Instantiate(_bullet, _weapon.position, _weapon.rotation);

            //bulet.transform.Translate(_weapon.transform.up * _force,Space.Self);
            //bulet.AddForce(transform.up * force, ForceMode2D.Impulse);
        }
        public void Rotation(Vector3 derection)
        {
            var angle = Mathf.Atan2(derection.y, derection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
