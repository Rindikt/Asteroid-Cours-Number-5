using UnityEngine;


namespace Asteroid
{
    internal class SpawnBullet : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Transform _transform;
        [SerializeField] private Sprite _bullet;
        [SerializeField] private float _forse = 10.0f;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                var go = Instantiate(prefab, _transform.position, transform.rotation);
                TestBuilder(go);
                Attack(go);
            }
        }

        [ContextMenu("Test Builder")]
        private void TestBuilder( GameObject gameObject)
        {
            var builder = new Builder(gameObject);
            var result = builder
                .Rigidbody2D(1f)
                .View
                .Name("Piy")
                .Sprite(_bullet);
        }
        private void Attack(GameObject gameObject)
        {
           var bullet = gameObject.GetComponent<Rigidbody2D>();
            bullet.AddForce(-_transform.up * _forse, ForceMode2D.Impulse);
        }
    }
}
