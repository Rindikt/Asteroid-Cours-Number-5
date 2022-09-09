using UnityEngine;
using System;
using Random = UnityEngine.Random;

namespace Asteroid
{
    internal class SpawnEnemy
    {
        private Transform _spawnPoint;
        private float _offset = 4.3f;
        private ViewServices _viewServices;
        private float _spawnTime { get; set; }
        private Vector3 _spawnPosition;
        public SpawnEnemy(Transform spawnPoint)
        {
            _viewServices = ViewServices.Instance();
            _spawnTime = Random.Range(2, 5);
            _spawnPoint = spawnPoint;
        }

        public void Execute()
        {
            if (_spawnTime > 0)
            {
                _spawnTime -= Time.deltaTime;
            }
            else
            {
                Spawn();
                _spawnTime = Random.Range(3, 10);

            }
        }
        public void Spawn()
        {
            _spawnPosition = GetSpawnPoint();
            int rand = Random.Range(0, 4);
            var enemy = new GameObject();

            switch (rand)
            {
                case 0:
                    enemy = _viewServices.Get(ManegerEnemy.ASTEROID_SMALL, StaticEnemyFactory.GetEnemy(EnemyType.AsteroidSmal, _spawnPosition));
                    if (enemy.TryGetComponent<EnemyAsteroid>(out EnemyAsteroid enemyASteroidSmal))
                    {
                        enemyASteroidSmal.demage = 2.0f;
                        enemyASteroidSmal._healPoint = 3.0f;
                        enemyASteroidSmal.Death += () => _viewServices.Destroy(ManegerEnemy.ASTEROID_SMALL, enemy);
                    }
                    break;
                case 1:
                    enemy = _viewServices.Get(ManegerEnemy.ASTEROID_MEDIUML, StaticEnemyFactory.GetEnemy(EnemyType.AsteroidMedium, _spawnPosition));
                    if (enemy.TryGetComponent<EnemyAsteroid>(out EnemyAsteroid enemyAsteroidMedium))
                    {
                        enemyAsteroidMedium.demage = 3.0f;
                        enemyAsteroidMedium._healPoint = 4.0f;
                        enemyAsteroidMedium.Death += () => _viewServices.Destroy(ManegerEnemy.ASTEROID_MEDIUML, enemy);
                    }
                    break;
                case 2:

                    enemy = _viewServices.Get(ManegerEnemy.ASTEROID_BIG, StaticEnemyFactory.GetEnemy(EnemyType.AsteroidBig, _spawnPosition));
                    if (enemy.TryGetComponent<EnemyAsteroid>(out EnemyAsteroid enemyAsteroidBig))
                    {
                        enemyAsteroidBig.demage = 4.0f;
                        enemyAsteroidBig._healPoint = 5.0f;
                        enemyAsteroidBig.Death += () => _viewServices.Destroy(ManegerEnemy.ASTEROID_BIG, enemy);
                    }


                    break;
                case 3:
                    enemy = _viewServices.Get(ManegerEnemy.LIGHT_FIGHTER, StaticEnemyFactory.GetEnemy(EnemyType.ShipFighter, _spawnPosition));
                    if (enemy.TryGetComponent<EnemyShip>(out EnemyShip EnemyShipFighter))
                    {
                        EnemyShipFighter._healPoint = 4.0f;
                        EnemyShipFighter.demage = 2.0f;
                        EnemyShipFighter.Death += () => _viewServices.Destroy(ManegerEnemy.LIGHT_FIGHTER, enemy);
                    }
                    break;
                default:
                    throw new Exception();
            }
        }

        private Vector3 GetSpawnPoint()
        {
            var spawnOffset = new Vector3(_spawnPoint.position.x, Random.Range(_spawnPoint.position.y - _offset, _spawnPoint.position.y + _offset), _spawnPoint.position.z);
            return spawnOffset;
        }

    }
}
