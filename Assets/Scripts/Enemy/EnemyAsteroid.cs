using UnityEngine;
using System;

namespace Asteroid
{
    internal class EnemyAsteroid : Enemy
    {
        public event Action Death = delegate () { };

        Health _health;
        private Vector2 _finishPos;
        private float _range = 20.0f;
        private float _speed = 2.0f;

        private void Awake()
        {
            _body = GetComponent<Rigidbody2D>();
            _finishPos = new Vector2(transform.position.x- _range, transform.position.y);
        }
        private void Start()
        {
            _health = new Health(_healPoint);
            
        }
        protected override void Move()
        {
            transform.position = Vector2.MoveTowards(transform.position, _finishPos, _speed * Time.deltaTime);
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.TryGetComponent<Bullet>( out Bullet bullet))
            {
                _healPoint = _health.GetDamage(bullet.demage);
                if (_healPoint <= 0)
                {

                    Death.Invoke();
                    Debug.Log(Death);
                }
            }
            if (collision.collider.CompareTag(TagManager.PLAYER)|| collision.collider.CompareTag(TagManager.FENCE))
            {
                Death.Invoke();
            }
        }

    }
}
