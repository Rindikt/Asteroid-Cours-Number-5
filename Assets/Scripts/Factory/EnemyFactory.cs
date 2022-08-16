using UnityEngine;


namespace Asteroid {
    public abstract class EnemyFactory : MonoBehaviour
    {
        private float _offset = 4.3f;
        protected Transform _spawnPoint;

        public Enemy Get(EnemyType type)
        {
            var spawnOffset = new Vector3(_spawnPoint.position.x, Random.Range(_spawnPoint.position.y - _offset, _spawnPoint.position.y + _offset), _spawnPoint.position.z);
            var scelet = Resources.Load<GameObject>("Enemy/EnemyCarcass");
            scelet = Object.Instantiate(scelet, spawnOffset, _spawnPoint.rotation);

            var viewEnemy = CreateEnemy(type, ref scelet);
            viewEnemy = Object.Instantiate(viewEnemy, spawnOffset, Quaternion.identity);
            viewEnemy.transform.SetParent(scelet.gameObject.transform);
            if (scelet.TryGetComponent(out Enemy enemy))
            {
                return enemy;
            }
            else
            {
                scelet.AddComponent<Enemy>();
                return enemy;
            } 
        }

        protected abstract GameObject CreateEnemy(EnemyType type, ref GameObject logic);
    }
}