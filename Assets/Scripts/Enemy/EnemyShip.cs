using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace Asteroid
{
    internal class EnemyShip : Enemy
    {
        public event Action Death = delegate () { };
        private Transform _player;
        public Transform _weapon;
        private GameObject _bullet;
        private Health _health;
        private float _stopDistance = 5;
        private float force = 3.0f;
        private float reload = 0;
        private IWeapon weapon;
        private void Awake()
        {
            _player = FindObjectOfType<Player>().transform;
            _body = GetComponent<Rigidbody2D>();
            _bullet = Resources.Load<GameObject>("Bullet/BulletEnemy");
            weapon = new DefaultWeapon(_weapon, _bullet);

        }
        private void Start()
        {
            _health = new Health(_healPoint);
        }
        private void Update()
        {
            Move();
        }
        protected override void Move()
        {
            var distance = (transform.position - _player.position).magnitude;
            transform.right = _player.position - transform.position;
            //Rotation(_player.transform.position);
            if (distance > _stopDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, _player.position, 0.02f);
            }
            else
            {
                if (reload > 0)
                {
                    reload -= 1 * Time.deltaTime;
                }
                else
                {
                    weapon.Attack();
                    reload = 2;
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
                    //Destroy(gameObject);
                    Death.Invoke();
                }
            }
        }
    }
}
