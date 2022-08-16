using UnityEngine;
namespace Asteroid
{
    internal class EnemyShip : Enemy
    {
        private Transform _player;
        private Rigidbody2D _bullet;
        private float _stopDistance = 5;
        private float force = 1.0f;
        private float reload = 7;
        private void Awake()
        {
            _player = FindObjectOfType<Player>().transform;
            _body = GetComponent<Rigidbody2D>();
            _bullet = Resources.Load<Rigidbody2D>("Bullet/BulletEnemy");
            transform.LookAt(_player);

        }
        private void Update()
        {
            Move();
        }
        protected override void Move()
        {
            Debug.Log("есть кто? 1lvl ");
            var distance = (transform.position - _player.position).magnitude;
            Rotation(_player.transform.position);
            if (distance > _stopDistance)
            {
                Debug.Log("есть кто? 2lvl ");
                Debug.Log(distance);
                transform.Translate((transform.position/*-_player.transform.position*/) * Time.deltaTime);
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
            
        }
        
        private void Attack()
        {
            var bulet = Object.Instantiate(_bullet, transform.position, transform.rotation);

            //bulet.transform.Translate(_weapon.transform.up * _force,Space.Self);
            bulet.AddForce(transform.up * force, ForceMode2D.Impulse);
        }
        public void Rotation(Vector3 derection)
        {
            var angle = Mathf.Atan2(derection.y, derection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
