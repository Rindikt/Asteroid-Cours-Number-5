using UnityEngine;

namespace Asteroid
{
    internal class EnemyAsteroid : Enemy
    {
       public EnemyAsteroid(float health)
        {
            _healPoint = health;
        }
        private void Awake()
        {
            _body = GetComponent<Rigidbody2D>();
        }
        protected override void Move()
        {
            
        }
        private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
        {
            
        }
    }
}
